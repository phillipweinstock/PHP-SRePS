using Grpc.Core;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PHP_SRePS_Backend
{
    public class StockService : StockDef.StockDefBase
    {

        private readonly ILogger<StockService> _logger;
        public StockService(ILogger<StockService> logger)
        {
            _logger = logger;
        }

        private AppDb db = new AppDb();

        private ItemService itemService;
        public override async Task<StockInfo> ChangeStock(StockTake request, ServerCallContext context)
        {

            await db.Connection.OpenAsync();

            var cmd = db.Connection.CreateCommand();

            // Database lookup with id
             cmd.CommandText = $"UPDATE STOCK SET item_stock={request.Info.Stock} WHERE item_id={request.Item.ItemId};";

            
            _ = await cmd.ExecuteReaderAsync();
            await cmd.DisposeAsync();

         

            //await Stock.CloseAsync();
           // await Stock.DisposeAsync();


           cmd.CommandText = $"SELECT * FROM STOCK WHERE item_id={request.Item.ItemId};";


            var Stock = await cmd.ExecuteReaderAsync();

            var Stockinfo = new StockInfo();
            await Stock.ReadAsync();


            Stockinfo.Stock = Stock.GetFieldValue<int>(2);

            await Stock.CloseAsync();
            await Stock.DisposeAsync();


            return (Stockinfo);

        }

        public override async Task GetAllStocks(HasChanged request, IServerStreamWriter<StockTake> responseStream, ServerCallContext context)

        {
            string query = "SELECT * FROM STOCKS;";

            await db.Connection.OpenAsync();
            var command = new MySqlCommand(query, db.Connection);
            var reader = await command.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                // Use item service to get the item
                Item item = await itemService.GetItem(new ItemGet()
                {
                    ItemId = reader.GetFieldValue<uint>(1)
                }, context);

                // Enter info into StockTake message
                var Stocktake = new StockTake
                {
                    Item = item,
                    Info = new StockInfo
                    {
                        Stock = reader.GetFieldValue<int>(2)
                    }
                };

                // send stock take over stream
                await responseStream.WriteAsync(Stocktake);
            }            
        }


        public override async Task<StockInfo> GetStock(Item request, ServerCallContext context)
        {


            await db.Connection.OpenAsync();

            var cmd = db.Connection.CreateCommand();

            // Database lookup with id
            cmd.CommandText = $"SELECT * FROM STOCK WHERE Item_id={request.ItemId};";


            var Stock = await cmd.ExecuteReaderAsync();

            var Stockinfo = new StockInfo();
            await Stock.ReadAsync();


            Stockinfo.Stock = Stock.GetFieldValue<int>(2);

            await Stock.CloseAsync();
            await Stock.DisposeAsync();


            return (Stockinfo);
        }
    }
}
