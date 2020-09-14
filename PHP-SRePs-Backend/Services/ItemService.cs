using System;
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
            
            using (var db = new AppDb())
            {
                db.Connection.OpenAsync();
                using var command = new MySqlCommand("SELECT sale_id FROM Sale;", db.Connection);
                using var reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    var value = reader.GetValue(0);
                    // do something with 'value'
                    _logger.LogWarning(value.ToString());
                }
            }
            return await Task.FromResult(new Item
            {
                // TODO: Return stuff   
            });
        }

        public override  Task<ItemList> GetAllItems(HasChanged request, ServerCallContext context)
        {

            return Task.FromResult(new ItemList
            {
                // TODO: Return stuff    
            });
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
