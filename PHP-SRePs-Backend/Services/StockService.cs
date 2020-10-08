using Grpc.Core;
using Microsoft.AspNetCore.WebUtilities;
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
        private AppDb db = new AppDb();

<<<<<<< HEAD
/*        public override async Task<StockTake> GetAllStocks(HasChanged request,IServerStreamWriter<StockTake> responseStream, ServerCallContext context)
=======
        //public override 

        public override StockInfo GetAllStocks(HasChanged request,IServerStreamWriter<StockTake>, ServerCallContext context)
>>>>>>> 76ca9473530439e4493eb657e71df5be196dd9d1
        {
            string query = "SELECT * FROM STOCKS;";

            await db.Connection.OpenAsync();
            var command = new MySqlCommand(query, db.Connection);
            var reader = await command.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                var Stocktake = new StockTake();
                {
                    StockTake. = (uint)(int)reader.GetValueAs(0);
                };
                await responseStream.WriteAsync();
        }*/
        public override async Task<StockInfo> GetStock(Item request, ServerCallContext context)
        {

            
            await db.Connection.OpenAsync();

            var cmd = db.Connection.CreateCommand();

            // Database lookup with id
            cmd.CommandText = $"SELECT * FROM STOCK WHERE Item_id={request.ItemId};";


            var Stock = await cmd.ExecuteReaderAsync();

            var Stockinfo = new StockInfo();
            await Stock.ReadAsync();


            Stockinfo.Stock =  Stock.GetFieldValue<int>(2);

                
            

            await Stock.CloseAsync();
            await Stock.DisposeAsync();

          
            return (Stockinfo);
        }

    }



}
