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
        private readonly ILogger<ItemService> _logger;
        public CategoryService(ILogger<ItemService> logger)
        {
            _logger = logger;
        }

        public override async Task<ErrorCodeReply> GetCategory(Category request, ServerCallContext context)
        {
            
            uint param1 = request.CategoryId;
            using (var db = new AppDb())
            {
                await db.Connection.OpenAsync();
                using var command = new MySqlCommand("INSERT INTO () VALUE ();", db.Connection);
                using var reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    var value = reader.GetValue(0);

                    // do something with 'value'
                }
            }

            return await Task.FromResult(new ErrorCodeReply
            {
                ErrorCode = false
            });
        }
    }
}
