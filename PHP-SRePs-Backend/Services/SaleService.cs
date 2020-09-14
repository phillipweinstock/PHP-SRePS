using System;
using System.Collections.Generic;
using System.Linq;
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
            _logger.LogDebug($"ItemId: {request.ItemDetails.ElementAt<AddSaleRequest.Types.ItemDetail>(1).ItemId}");

            // Get ItemDetails at index
            _ = request.ItemDetails.ElementAt<AddSaleRequest.Types.ItemDetail>(1).Quantity;

            // List Size of ItemDetails sent
            _logger.LogDebug($"Count: {request.ItemDetails.Count}");


            // TODO: database stuff
            // Conn to db

            using (var db = new AppDb())
            {
                await db.Connection.OpenAsync();
                using var command = new MySqlCommand("SELECT cat_id FROM Category;", db.Connection);
                using var reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    var value = reader.GetValue(0);

                    // do something with 'value'
                    _logger.LogWarning(value.ToString());
                }
            }

            //_logger.LogCritical(Configuration.GetConnectionString("Default"));

            // db updated successfully?
            bool dbUpdateSuccess = false;

            // get this saleid - used later
            uint saleid;

            int itemCount = request.ItemDetails.Count;

            // Loop to add items to ItemDetail table
            foreach (var itemDetail in request.ItemDetails)
            {
                // insert saleid into ItemDetail

                // insert info from request
                _ = itemDetail.ItemId;
                _ = itemDetail.Quantity;

                // insert item id into sales database ??????????
            }

            // insert into sale table
            _ = request.TotalBilled;

            // Done?

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
