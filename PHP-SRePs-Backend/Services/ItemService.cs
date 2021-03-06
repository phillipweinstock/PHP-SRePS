using Grpc.Core;
using Microsoft.Extensions.Logging;
using MySqlConnector;
using System.Threading.Tasks;

namespace PHP_SRePS_Backend
{
    public class ItemService : ItemDef.ItemDefBase
    {
        private AppDb db = new AppDb();
        private readonly ILogger<ItemService> _logger;
        public ItemService(ILogger<ItemService> logger)
        {
            _logger = logger;

        }

        public override async Task<Item> GetItem(ItemGet request, ServerCallContext context)
        {

            Item item = new Item();
            string query = $"SELECT * FROM item WHERE item_id={request.ItemId} OR name='{request.NameId}';";
            await db.Connection.OpenAsync();
            using var command = new MySqlCommand(query, db.Connection);
            using var reader = await command.ExecuteReaderAsync();
            await reader.ReadAsync();

            item.ItemId = reader.GetFieldValue<uint>(0);
            item.PriceId = reader.GetFieldValue<float>(1);
            item.NameId = reader.GetFieldValue<string>(2);
            item.CatagoryId = reader.GetFieldValue<uint>(3);



            _logger.LogInformation("Items requested");
            return item;
        }

        public override async Task GetAllItems(HasChanged request, IServerStreamWriter<Item> responseStream, ServerCallContext context)
        {
            _logger.LogInformation("All items requested");

            string query = "SELECT * FROM item;";

            await db.Connection.OpenAsync();
            var command = new MySqlCommand(query, db.Connection);
            var reader = await command.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                Item item = new Item
                {
                    ItemId = (uint)(int)reader.GetValue(0),
                    PriceId = (float)(decimal)reader.GetValue(1),
                    NameId = (string)reader.GetValue(2),
                    CatagoryId = (uint)(int)reader.GetValue(3)
                };
                await responseStream.WriteAsync(item);
            }
            await reader.CloseAsync();
            await db.Connection.CloseAsync();

            _logger.LogInformation("All items sent");
        }



        public override async Task<ErrorCodeReply> AddItem(Item request, ServerCallContext context)
        {
            string query = $"INSERT INTO ITEM (price,name,cat_id) " +
                           $"VALUES ({request.PriceId},\"{request.NameId}\",{request.CatagoryId});";

            await db.Connection.OpenAsync();
            var command = new MySqlCommand(query, db.Connection);
            var reader = await command.ExecuteReaderAsync();
            reader.ConfigureAwait(true);


            bool recordsAffected = (reader.RecordsAffected == 1);

            await reader.CloseAsync();
            await db.Connection.CloseAsync();

            _logger.LogInformation($"Added item '{request.NameId}' to item table");

            return (new ErrorCodeReply
            {
                ErrorCode = recordsAffected
            });
        }

        public override async Task<ErrorCodeReply> DeleteItem(Item request, ServerCallContext context)
        {

            string query = $"DELETE FROM ITEM WHERE item_id = {request.ItemId} OR name = \"{request.NameId}\" ;";

            await db.Connection.OpenAsync();
            var command = new MySqlCommand(query, db.Connection);
            var reader = await command.ExecuteReaderAsync();
            reader.ConfigureAwait(true);


            bool recordsAffected = (reader.RecordsAffected == 1);

            await reader.CloseAsync();
            await db.Connection.CloseAsync();

            _logger.LogInformation($"Removed item from item table");

            return (new ErrorCodeReply
            {
                ErrorCode = recordsAffected
            });
        }
        public override async Task<ErrorCodeReply> AlterItem(AlteredItem request, ServerCallContext context)
        {

            string query = $"UPDATE ITEM " +
                           $"SET name=;{request.AlteredItem_.NameId},price={request.AlteredItem_.PriceId}" +
                           $",cat_id{request.AlteredItem_.CatagoryId} " +
                           $"WHERE item_id={request.ItemOriginal.ItemId}";
            await db.Connection.OpenAsync();
            var command = new MySqlCommand(query, db.Connection);
            var reader = await command.ExecuteReaderAsync();
            reader.ConfigureAwait(true);


            bool recordsAffected = (reader.RecordsAffected == 1);

            await reader.CloseAsync();
            await db.Connection.CloseAsync();

            _logger.LogInformation($"Removed item from item table");

            return (new ErrorCodeReply
            {
                ErrorCode = recordsAffected
            });
        }
    }
}
