using Grpc.Core;
using Microsoft.Extensions.Logging;
using MySqlConnector;
using System.Threading.Tasks;

namespace PHP_SRePS_Backend
{
    public class ReportService : ReportDef.ReportDefBase
    {
        private AppDb db = new AppDb();
        private readonly ILogger<ReportService> _logger;
        public ReportService(ILogger<ReportService> logger)
        {
            _logger = logger;
        }

        public override async Task GetMontlyReport(DateGet request, IServerStreamWriter<MonthlyItemInfo> responseStream, ServerCallContext context)
        {
            _logger.LogInformation("IN");


            MySqlConnection db = new AppDb().Connection;
            await db.OpenAsync();

            var cmd = db.CreateCommand();

            cmd.CommandText = "SELECT ITEM.item_id, ITEM.name, SUM(ITEMDETAIL.quantity), SUM(ITEMDETAIL.quantity)* ITEM.price" +
                              " FROM ITEMDETAIL" +
                              " JOIN ITEM ON ITEMDETAIL.item_id = ITEM.item_id" +
                              " JOIN SALE ON sale.sale_id = ITEMDETAIL.sale_id" +
                              $" WHERE month(date)={request.Month} AND year(date)={request.Year}" +
                              " GROUP BY ITEM.item_id" +
                              " ORDER BY SALE.sale_id;";

            var reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                await responseStream.WriteAsync(new MonthlyItemInfo
                {
                    ItemId = reader.GetFieldValue<uint>(0),
                    ItemName = reader.GetFieldValue<string>(1),
                    QtySold = reader.GetFieldValue<float>(2),
                    ItemRevenue = reader.GetFieldValue<float>(3)
                });
            }

            await reader.CloseAsync();
            await db.CloseAsync();
            await db.DisposeAsync();
        }
    }
}
