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

            foreach (var itemDetail in request.ItemDetails)
            {
                _logger.LogInformation($"Id : {itemDetail.ItemId}, quant : {itemDetail.Quantity}");
            }

            // Print to console
            _logger.LogDebug($"ItemId: {request.ItemDetails.ElementAt<AddSaleRequest.Types.ItemDetail>(0).ItemId}");

            // Get ItemDetails at index
            _ = request.ItemDetails.ElementAt<AddSaleRequest.Types.ItemDetail>(0).Quantity;

            // List Size of ItemDetails sent
            _logger.LogDebug($"Count: {request.ItemDetails.Count}");

            // db updated successfully?
            bool dbUpdateSuccess = false;

            using (var db = new AppDb())
            {
                await db.Connection.OpenAsync();

                _logger.LogDebug($"connection opened");

                using var cmd = db.Connection.CreateCommand();

                // Create a new blank sale to edit
                cmd.CommandText = $"insert into sale (datetime) Values (NOW());";
                await cmd.ExecuteNonQueryAsync();

                var command = new MySqlCommand("SELECT sale_id FROM Sale ORDER BY sale_id DESC LIMIT 1;", db.Connection);
                var reader = await command.ExecuteReaderAsync();
                await reader.ReadAsync();

                // get this saleid - used later
                int saleid =  (reader.GetFieldValue<int>(0));
                
                _logger.LogWarning($"saleid : {saleid}");

                await reader.CloseAsync();

                //Get next Item id
                command.CommandText = "SELECT item_detail_id FROM itemdetail ORDER BY item_detail_id DESC LIMIT 1;";
                reader = await command.ExecuteReaderAsync();
                await reader.ReadAsync();
                // get this itemid
                int itemdetailid = (reader.GetFieldValue<int>(0) + 1);
                _logger.LogWarning($"itemdetailid : {itemdetailid}");

                await reader.CloseAsync();

                // Loop to add items to ItemDetail table
                foreach (var itemDetail in request.ItemDetails)
                {
                    // insert saleid into ItemDetail
                    cmd.CommandText = $"insert into itemdetail (quantity, item_id) OUTPUT Values ({itemDetail.ItemId}, {itemDetail.Quantity})";

                    await cmd.ExecuteNonQueryAsync();
                }

                // update sale
                cmd.CommandText = $"update sale set total_billed={request.TotalBilled}, item_detail_id={itemdetailid} where sale_id={saleid};";

                await cmd.ExecuteNonQueryAsync();

                _logger.LogCritical("DONE?");

                /*while (await reader.ReadAsync())
                {
                    saleid = (int)(reader.GetValue(0));
                    var value2 = reader.GetValue(1);

                    // do something with 'value'
                    _logger.LogWarning($"{saleid} : {value2}");
                }*/

                //_logger.LogCritical(Configuration.GetConnectionString("Default"));

            }

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
                _logger.LogDebug($"ID: {request.SaleId}");

                // TODO: Database lookup with id

            } else if(request.SaleDate != "")
            {
                _logger.LogDebug($"Date: {request.SaleDate}");

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
