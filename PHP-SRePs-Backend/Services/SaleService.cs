using Grpc.Core;
using Microsoft.Extensions.Logging;
using MySqlConnector;
using System.Collections.Generic;
using System.Threading.Tasks;
using static PHP_SRePS_Backend.SaleInfo.Types;

namespace PHP_SRePS_Backend
{
    public class SaleService : SaleDef.SaleDefBase
    {
        private readonly ILogger<SaleService> _logger;
        public SaleService(ILogger<SaleService> logger)
        {
            _logger = logger;
        }

        public override async Task<ErrorCodeReply> AddSale(AddSaleRequest request, ServerCallContext context)
        {
            // List Size of ItemDetails sent
            _logger.LogDebug($"Count: {request.ItemDetails.Count}");

            // db updated successfully?
            bool dbUpdateSuccess = false;

            MySqlConnection db = new AppDb().Connection;
            await db.OpenAsync();

            var cmd = db.CreateCommand();
            MySqlTransaction myTrans = await db.BeginTransactionAsync();
            cmd.Transaction = myTrans;

            _logger.LogDebug($"connection opened");

            // Create a new sale
            cmd.CommandText = $"insert into sale (total_billed, date) Values ({request.TotalBilled}, NOW()); SELECT LAST_INSERT_ID();";
            var reader = await cmd.ExecuteReaderAsync();
            await reader.ReadAsync();

            // get this saleid - used later
            int saleid = reader.GetFieldValue<int>(0);
            await reader.CloseAsync();

            _logger.LogWarning($"saleid : {saleid}");

            // Loop to add items to ItemDetail table
            foreach (var itemDetail in request.ItemDetails)
            {
                _logger.LogInformation($"{itemDetail.ItemName}");

                // Find item
                cmd.CommandText = $"SELECT item_id FROM item WHERE name=\"{itemDetail.ItemName}\"";
                reader = await cmd.ExecuteReaderAsync();
                await reader.ReadAsync();
                int itemid = reader.GetFieldValue<int>(0);
                await reader.CloseAsync();

                _logger.LogInformation($"Itemid: {itemid}");

                // insert saleid into ItemDetail
                cmd.CommandText = $"insert into itemdetail (item_id, quantity, sale_id) Values ({itemid}, {itemDetail.Quantity}, {saleid})";

                await cmd.ExecuteNonQueryAsync();
            }

            await myTrans.CommitAsync();
            await db.CloseAsync();

            _logger.LogCritical("DONE?");


            return await Task.FromResult(new ErrorCodeReply
            {
                ErrorCode = dbUpdateSuccess
            });
        }

        public override async Task<SaleInfo> GetSale(SaleGet request, ServerCallContext context)
        {

            MySqlConnection db = new AppDb().Connection;
            await db.OpenAsync();

            var cmd = db.CreateCommand();

            // Database lookup with id
            cmd.CommandText = "SELECT ITEM.item_id, ITEM.name, ITEM.price, ITEMDETAIL.quantity, SALE.total_billed " +
                                   "FROM ITEMDETAIL " +
                                   "JOIN ITEM ON ITEMDETAIL.item_id = ITEM.item_id " +
                                   "JOIN SALE ON sale.sale_id = ITEMDETAIL.sale_id " +
                                   $"WHERE SALE.sale_id = {request.SaleId};";


            var salesinfo = await cmd.ExecuteReaderAsync();
            var totalBilled = 0f;

            // get item infos
            List<ItemRequestDetails> iteminfos = new List<ItemRequestDetails>();
            while (await salesinfo.ReadAsync())
            {
                iteminfos.Add(new ItemRequestDetails
                {
                    ItemId = salesinfo.GetFieldValue<uint>(0),
                    Name = salesinfo.GetFieldValue<string>(1),
                    Price = salesinfo.GetFieldValue<float>(2),
                    Quantity = salesinfo.GetFieldValue<uint>(3)
                });

                totalBilled = salesinfo.GetFieldValue<float>(4);
            }

            await salesinfo.CloseAsync();

            await db.CloseAsync();
            await db.DisposeAsync();

            // TODO: proper return
            return await Task.FromResult(new SaleInfo
            {
                ItemDetails = { iteminfos },
                SaleId = request.SaleId,
                TotalBilled = totalBilled
            });
        }

        public override async Task GetAllSales(HasChanged request, IServerStreamWriter<SaleInfo> responseStream, ServerCallContext context)
        {
            MySqlConnection db = new AppDb().Connection;
            await db.OpenAsync();

            var cmd = db.CreateCommand();

            // TODO: Database lookup with id
            cmd.CommandText = "SELECT SALE.sale_id, ITEM.item_id, ITEM.name, ITEM.price, ITEMDETAIL.quantity, SALE.total_billed " +
                                   "FROM ITEMDETAIL " +
                                   "JOIN ITEM ON ITEMDETAIL.item_id = ITEM.item_id " +
                                   "JOIN SALE ON sale.sale_id = ITEMDETAIL.sale_id " +
                                   "ORDER BY SALE.sale_id";

            var reader = await cmd.ExecuteReaderAsync();

            // initialise
            uint saleId = 0;
            float totalBill = 0f;
            List<ItemRequestDetails> itemInfos = new List<ItemRequestDetails>();

            while (await reader.ReadAsync())
            {
                // if the current id does not equal the previous id
                if (reader.GetFieldValue<uint>(0) != saleId)
                {
                    // send the data
                    if(saleId != 0)
                        await responseStream.WriteAsync(new SaleInfo
                        {
                            SaleId = saleId,
                            ItemDetails = { itemInfos },
                            TotalBilled = totalBill
                        });

                    // reset to current info
                    saleId = reader.GetFieldValue<uint>(0);
                    totalBill = reader.GetFieldValue<float>(5);
                    itemInfos.Clear();
                }

                // Add item information
                itemInfos.Add(new ItemRequestDetails
                {
                    ItemId = reader.GetFieldValue<uint>(1),
                    Name = reader.GetFieldValue<string>(2),
                    Price = reader.GetFieldValue<float>(3),
                    Quantity = reader.GetFieldValue<uint>(4)
                });
            }

            // Final send - last sale id
            await responseStream.WriteAsync(new SaleInfo
            {
                SaleId = saleId,
                ItemDetails = { itemInfos },
                TotalBilled = totalBill
            });

            await reader.CloseAsync();

            await db.CloseAsync();
            await db.DisposeAsync();
        }
    }
}
