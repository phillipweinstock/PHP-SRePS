using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using MySqlConnector;

namespace PHP_SRePS_Backend
{
    public class CategoryService : CategoryDef.CategoryDefBase
    {
        private AppDb db = new AppDb();
        private readonly ILogger<ItemService> _logger;
        public CategoryService(ILogger<ItemService> logger)
        {
            _logger = logger;
        }
        public override async Task<ErrorCodeReply> GetCategory(Category request, ServerCallContext context)
        {
            //Item item = new Item();

            string query = $"SELECT * FROM category WHERE cat_id={request.CategoryId} );";
            await db.Connection.OpenAsync();
            using var command = new MySqlCommand(query, db.Connection);
            using var reader = await command.ExecuteReaderAsync();
            await reader.CloseAsync();
            await db.Connection.CloseAsync();

            


            _logger.LogError("All items requested");
            return (new ErrorCodeReply
            {
                ErrorCode = false
            });
        }
        public override async Task<ErrorCodeReply> DeleteCategory(Category request, ServerCallContext context)
        {
  
            string query = $"DELETE FROM category WHERE cat_id={request.CategoryId} );";
            await db.Connection.OpenAsync();
            using var command = new MySqlCommand(query, db.Connection);
            using var reader = await command.ExecuteReaderAsync();
            await reader.CloseAsync();
            await db.Connection.CloseAsync();

            ErrorCodeReply error = new ErrorCodeReply
            {
                ErrorCode =!( reader.RecordsAffected == 1)
            };


            _logger.LogError("Delete Category");
            return error ;
        }

        public override async Task<ErrorCodeReply> AddCategory(Category request, ServerCallContext context)
        {

            string query = $"INSERT INTO category (name,cat_desc) values ({request.Name},{request.CatDesc});";

           
                await db.Connection.OpenAsync();
                using var command = new MySqlCommand(query, db.Connection);
                using var reader = await command.ExecuteReaderAsync();
                
                await reader.CloseAsync();
                await db.Connection.CloseAsync();
            

            return (new ErrorCodeReply
            {
                ErrorCode = false
            });
        }
    }
}
