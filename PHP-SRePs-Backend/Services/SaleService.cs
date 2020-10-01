using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.AspNetCore.SignalR.Protocol;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MySqlConnector;

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
            // db updated successfully?
            bool dbUpdateSuccess = false;

            MySqlConnection db = new AppDb().Connection;
            await db.OpenAsync();

            var cmd = db.CreateCommand();
            MySqlTransaction myTrans = await db.BeginTransactionAsync();
            cmd.Transaction = myTrans;

            // Create a new sale
            cmd.CommandText = $"insert into sale (total_billed, date) Values (0, NOW()); SELECT LAST_INSERT_ID();";
            var reader = await cmd.ExecuteReaderAsync();
            await reader.ReadAsync();

            // get this saleid - used later
            int saleid = reader.GetFieldValue<int>(0);
            await reader.CloseAsync();

            float totalBilled = 0f;
            // Loop to add items to ItemDetail table
            foreach (var itemDetail in request.ItemDetails)
            {
                // Find item
                cmd.CommandText = $"SELECT item_id, price FROM item WHERE name=\"{itemDetail.ItemName}\"";
                reader = await cmd.ExecuteReaderAsync();
                await reader.ReadAsync();

                int itemid = reader.GetFieldValue<int>(0);
                totalBilled += reader.GetFieldValue<float>(1) * itemDetail.Quantity;

                await reader.CloseAsync();

                // insert saleid into ItemDetail
                cmd.CommandText = $"insert into itemdetail (item_id, quantity, sale_id) Values ({itemid}, {itemDetail.Quantity}, {saleid})";

                await cmd.ExecuteNonQueryAsync();
            }

            // update saleid to proper 
            cmd.CommandText = $"UPDATE sale SET total_billed = {totalBilled} WHERE sale_id = {saleid}";
            reader = await cmd.ExecuteReaderAsync();
            await reader.ReadAsync();
            await reader.CloseAsync();

            await myTrans.CommitAsync();
            await db.CloseAsync();

            _logger.LogInformation($"Sale with id {saleid}, successfully added to the database");

            return await Task.FromResult(new ErrorCodeReply
            {
                ErrorCode = dbUpdateSuccess
            });
        }

        public override async Task GetSale(SaleGet request, IServerStreamWriter<SaleInfo> responseStream, ServerCallContext context)
        {

            MySqlConnection db = new AppDb().Connection;
            await db.OpenAsync();

            var cmd = db.CreateCommand();

            // Sale information which will be returned
            SaleInfo returnInfo = new SaleInfo();

            if (request.SaleId > 0) // saleId will be set to 0 if not specified
            {
                _logger.LogDebug($"ID: {request.SaleId.ToString()}");

                // TODO: Database lookup with id
                cmd.CommandText = $"SELECT sale_id, total_billed FROM sale WHERE sale_id={request.SaleId}";
                var salesinfo = await cmd.ExecuteReaderAsync();
                await salesinfo.ReadAsync();
                
                if (salesinfo.HasRows)
                {
<<<<<<< HEAD
                    uint saleid = salesinfo.GetFieldValue<uint>(0);
=======
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
            _logger.LogInformation("All sales requested");

            MySqlConnection db = new AppDb().Connection;
            await db.OpenAsync();
>>>>>>> a0444af1d44370021400c67c035bbfa27519efdf

                    await salesinfo.CloseAsync();

<<<<<<< HEAD
                    cmd.CommandText = $"SELECT item_id, quantity FROM itemdetail WHERE sale_id={saleid}";
                    var reader = await cmd.ExecuteReaderAsync();
=======
            // Database lookup with id
            cmd.CommandText = "SELECT SALE.sale_id, ITEM.item_id, ITEM.name, ITEM.price, ITEMDETAIL.quantity, SALE.total_billed " +
                                   "FROM ITEMDETAIL " +
                                   "JOIN ITEM ON ITEMDETAIL.item_id = ITEM.item_id " +
                                   "JOIN SALE ON sale.sale_id = ITEMDETAIL.sale_id " +
                                   "ORDER BY SALE.sale_id";

            var reader = await cmd.ExecuteReaderAsync();
>>>>>>> a0444af1d44370021400c67c035bbfa27519efdf

                    // get item infos
                    List<SaleInfo.Types.ItemRequestDetails> iteminfos = new List<SaleInfo.Types.ItemRequestDetails>();
                    while(await reader.ReadAsync())
                    {
                        uint itemid = reader.GetFieldValue<uint>(0);

                        cmd.CommandText = $"SELECT name, price FROM item WHERE item_id={itemid}";
                        var reader2 = await cmd.ExecuteReaderAsync();
                        while(await reader2.ReadAsync())
                        {
                            iteminfos.Add(new SaleInfo.Types.ItemRequestDetails
                            {
                                ItemId = reader.GetFieldValue<uint>(0),
                                Name = reader2.GetFieldValue<string>(0),
                                Price = reader2.GetFieldValue<float>(1),
                                Quantity = reader.GetFieldValue<uint>(1)
                            });
                        }

                        await reader2.CloseAsync();
                    }

                    returnInfo = new SaleInfo
                    {
                        ItemDetails = { iteminfos },
                        SaleId = salesinfo.GetFieldValue<uint>(0),
                        TotalBilled = salesinfo.GetFieldValue<float>(1)
                    };

                    await reader.CloseAsync();
                }
                await salesinfo.CloseAsync();

            } else if(request.SaleDate != "")
            {
                _logger.LogDebug($"Date: {request.SaleDate.ToString()}");

                // TODO: get all sales in db for date
                returnInfo = new SaleInfo();
            } else
            {
                // No info recieved
                _logger.LogError($"No information sent in GetSale request");

                // Return 0 sale id - indicating an issue occured
                //returnInfo.SaleId = 0;
                returnInfo = new SaleInfo();
            }

<<<<<<< HEAD
            // TODO: proper return
            await responseStream.WriteAsync(returnInfo);
        }

        public override async Task GetAllSales(HasChanged request, IServerStreamWriter<SaleInfo> responseStream, ServerCallContext context)
        {
            // TODO: Do stuff
            await base.GetAllSales(request, responseStream, context);
=======
            await db.CloseAsync();
            await db.DisposeAsync();

            _logger.LogInformation("All sales sent");
        }


        public override async Task<ErrorCodeReply> DeleteSale(SaleGet request, ServerCallContext context)
        {
            

            return await base.DeleteSale(request, context);
        }

        public override async Task<ErrorCodeReply> AlterSale(EditSaleRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"LOG INFO: {request.SaleId}, {request.TotalBilled}");

            if(request.SaleId <= 0 || request.TotalBilled < 0)
            {
                return await Task.FromResult(new ErrorCodeReply
                {
                    ErrorCode = false
                });
            }

            

            foreach(var itemDetail in request.ItemDetails)
            {
                _logger.LogInformation($"LOG INFO ITEM DETAIL: {itemDetail.ItemName}, {itemDetail.Quantity}");
            }

            


            return await Task.FromResult(new ErrorCodeReply
            {
                ErrorCode = true
            });
>>>>>>> a0444af1d44370021400c67c035bbfa27519efdf
        }
    }
}
