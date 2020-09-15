using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using MySqlConnector;

namespace PHP_SRePS_Backend
{
    public class ItemService : ItemDef.ItemDefBase
    {
        private readonly ILogger<ItemService> _logger;
        public ItemService(ILogger<ItemService> logger)
        {
            _logger = logger;
        }

        public override async Task<Item> GetItem(ItemGet request, ServerCallContext context)
        {

            Item item = new Item();
            string query = $"SELECT * FROM item WHERE item_id = {request.ItemId} );";
            using (var db = new AppDb())
            {
                await db.Connection.OpenAsync();
                using var command = new MySqlCommand(query, db.Connection);
                using var reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    item.ItemId = reader.GetFieldValue<uint>(0);
                    item.PriceId = reader.GetFieldValue<float>(1);
                    item.NameId = reader.GetFieldValue<string>(2);
                    item.CatagoryId = reader.GetFieldValue<uint>(3);

                }
            }
             _logger.LogError("All items requested");
            return await Task.FromResult(item);
        }

        public override async Task<ItemList> GetAllItems(HasChanged request, ServerCallContext context)
        {
            ItemList list = new ItemList();
            string query = "SELECT * FROM item ;";
            using (var db = new AppDb())
            {
                await db.Connection.OpenAsync();
                using var command = new MySqlCommand(query, db.Connection);
                using var reader = await command.ExecuteReaderAsync();
                List<Item> temp = new List<Item>();
                while (await reader.ReadAsync())
                {
                    Item item = new Item();
                    item.ItemId  = (uint)(int)reader.GetValue(0);
                    item.PriceId = (float)(decimal)reader.GetValue(1);
                    item.NameId  = (string)reader.GetValue(2);
                    item.CatagoryId = (uint)(int)reader.GetValue(3);

                    temp.Add(item);


                }
                
                list.ItemList_.Add(temp);
            }
            return await Task.FromResult(list);
        }

        public override Task<ErrorCodeReply> AddItem(Item request, ServerCallContext context)
        {

            return Task.FromResult(new ErrorCodeReply
            {
                // TODO: Return stuff     
            });
        }

        public override Task<ErrorCodeReply> DeleteItem(Item request, ServerCallContext context)
        {

            return Task.FromResult(new ErrorCodeReply
            {
                // TODO: Return stuff   
            });
        }
    }
}
