using Grpc.Core;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHP_SRePS_Backend
{
    public class StockService : StockDef.StockDefBase
{
        private AppDb db = new AppDb();

        public override async Task<StockInfo> GetStock(Item request, ServerCallContext context)
        {

            
            //await db.Connection.OpenAsync();

         //   var cmd = db.Connection.

            // Database lookup with id
          /*  cmd.CommandText = "SELECT ITEM.item_id, ITEM.name, ITEM.price, ITEMDETAIL.quantity, SALE.total_billed " +
                                   "FROM ITEMDETAIL " +
                                   "JOIN ITEM ON ITEMDETAIL.item_id = ITEM.item_id " +
                                   "JOIN SALE ON sale.sale_id = ITEMDETAIL.sale_id " +
                                   $"WHERE SALE.sale_id = {request.SaleId};";*/

/*
            var salesinfo = await cmd.ExecuteReaderAsync();
            
           
            while (await salesinfo.ReadAsync())
            {
               

                totalBilled = salesinfo.GetFieldValue<float>(4);
            }

            await salesinfo.CloseAsync();

            await db.CloseAsync();
            await db.DisposeAsync();
*/
          
            return (new StockInfo());
        }

    }



}
