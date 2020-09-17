using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Grpc.Core;
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
        public IConfiguration Configuration
        {
            get; private set;
        }

        public override async Task<ErrorCodeReply> AddSale(AddSaleRequest request, ServerCallContext context)
        {


            // Print to console
            //_logger.LogDebug($"ItemId: {request.ItemDetails.ElementAt<AddSaleRequest.Types.ItemDetail>(0).ItemId}");

            // Get ItemDetails at index
            //_ = request.ItemDetails.ElementAt<AddSaleRequest.Types.ItemDetail>(0).Quantity;

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
            /*while (await reader.ReadAsync())
            {
                saleid = (int)(reader.GetValue(0));
                var value2 = reader.GetValue(1);

                // do something with 'value'
                _logger.LogWarning($"{saleid} : {value2}");
            }*/

            //_logger.LogCritical(Configuration.GetConnectionString("Default"));

           

            _logger.LogCritical("DONE?");

            return await Task.FromResult(new ErrorCodeReply
            {
                ErrorCode = dbUpdateSuccess
            });
        }

        public override async Task GetSale(SaleGet request, IServerStreamWriter<SaleInfo> responseStream, ServerCallContext context)
        {
            // Sale information which will be returned
            SaleInfo returnInfo = new SaleInfo();
            
            if(request.SaleId > 0) // saleId will be set to 0 if not specified
            {
                _logger.LogDebug($"ID: {request.SaleId.ToString()}");

                // TODO: Database lookup with id

            } else if(request.SaleDate != "")
            {
                _logger.LogDebug($"Date: {request.SaleDate.ToString()}");

                // TODO: get all sales in db for date

            } else
            {
                // No info recieved
                _logger.LogError($"No information sent in GetSale request");

                // Return 0 sale id - indicating an issue occured
                returnInfo.SaleId = 0;

                // TODO: return proper error
                await responseStream.WriteAsync(returnInfo);
            }

            // TODO: proper return
            await responseStream.WriteAsync(returnInfo);
        }

        public override async Task GetAllSales(HasChanged request, IServerStreamWriter<SaleInfo> responseStream, ServerCallContext context)
        {
            // TODO: Do stuff
            await base.GetAllSales(request, responseStream, context);
        }
    }
}
