using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace PHP_SRePS_Backend
{
    public class ItemService : ItemDef.ItemDefBase
    {
        private readonly ILogger<ItemService> _logger;
        public ItemService(ILogger<ItemService> logger)
        {
            _logger = logger;
        }

        public override Task<Item> GetItem(ItemGet request, ServerCallContext context)
        {
            
            return Task.FromResult(new Item
            {
                // TODO: Return stuff   
            }) ;
        }

        public override Task<ItemList> GetAllItems(HasChanged request, ServerCallContext context)
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
