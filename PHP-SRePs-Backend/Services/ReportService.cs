using Grpc.Core;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.Extensions.Logging;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHP_SRePS_Backend
{
    public class ReportService : ReportDef.ReportDefBase
    {
        public static void LinearRegression(double[] xVals, double[] yVals,
                                        int inclusiveStart, int exclusiveEnd,
                                        out double rsquared, out double yintercept,
                                        out double slope)
        {
            //https://stackoverflow.com/questions/15623129/simple-linear-regression-for-data-set
            double sumOfX = 0;
            double sumOfY = 0;
            double sumOfXSq = 0;
            double sumOfYSq = 0;
            double ssX = 0;
            double ssY = 0;
            double sumCodeviates = 0;
            double sCo = 0;
            double count = exclusiveEnd - inclusiveStart;

            for (int ctr = inclusiveStart; ctr < exclusiveEnd; ctr++)
            {
                double x = xVals[ctr];
                double y = yVals[ctr];
                sumCodeviates += x * y;
                sumOfX += x;
                sumOfY += y;
                sumOfXSq += x * x;
                sumOfYSq += y * y;
            }
            ssX = sumOfXSq - ((sumOfX * sumOfX) / count);
            ssY = sumOfYSq - ((sumOfY * sumOfY) / count);
            double RNumerator = (count * sumCodeviates) - (sumOfX * sumOfY);
            double RDenom = (count * sumOfXSq - (sumOfX * sumOfX))
             * (count * sumOfYSq - (sumOfY * sumOfY));
            sCo = sumCodeviates - ((sumOfX * sumOfY) / count);

            double meanX = sumOfX / count;
            double meanY = sumOfY / count;
            double dblR = RNumerator / Math.Sqrt(RDenom);
            rsquared = dblR * dblR;
            yintercept = meanY - ((sCo / ssX) * meanX);
            slope = sCo / ssX;
        }
        private AppDb db = new AppDb();
        private readonly ILogger<ReportService> _logger;
        public ReportService(ILogger<ReportService> logger)
        {
            _logger = logger;
        }






        public override async Task<LinearItemInfo> GetPredictionReport(LinearGet request, ServerCallContext context)
        {
            _logger.LogInformation($"Requested month: {request.DateInfo.Month}, year: {request.DateInfo.Year}");


            MySqlConnection db = new AppDb().Connection;
            await db.OpenAsync();
            var cmd = db.CreateCommand();

            cmd.CommandText = $"SELECT SUM(ITEMDETAIL.quantity) as QtySold" +
                $"FROM ITEMDETAIL" +
                $"JOIN ITEM ON ITEMDETAIL.item_id = ITEM.item_id" +
                $"JOIN SALE ON sale.sale_id = ITEMDETAIL.sale_id" +
                $"WHERE ITEM.item_id ={request.ItemId} AND month(date)={request.DateInfo.Month} AND year(date)={request.DateInfo.Year}" +
                "GROUP BY ITEM.item_id, day(date)" +
                "ORDER BY SALE.sale_id; ";
            var reader = await cmd.ExecuteReaderAsync();
            List<double> sales = new List<double>();
            while (await reader.ReadAsync())
            {
                sales.Add(reader.GetFieldValue<double>(0)); //List of Y values, with X as the index
            }
            double[] xvals = new double[sales.Count];
            double[] yvals = new double[sales.Count];

            for (int i =0; i < sales.Count -1; i++)
            {
                xvals[i] = i + 1;
            }
            yvals = sales.ToArray();
            double rsquared, yint, slope;
            LinearRegression(xvals, yvals, 0, sales.Count - 1, out rsquared, out yint, out slope);
            List<ReducedItemInfo> item_info = new List<ReducedItemInfo>();
            item_info.AddRange((IEnumerable<ReducedItemInfo>)sales.AsEnumerable());//May cause error
            return (new LinearItemInfo()
            {
                YIntercept = yint,
                BSlope = slope,
                Rsquared = rsquared,
                Sales = { item_info }

            }) ;
        }
        public override async Task GetMonthlyReport(DateGet request, IServerStreamWriter<MonthlyItemInfo> responseStream, ServerCallContext context)
        {
            _logger.LogInformation($"Requested month: {request.Month}, year: {request.Year}");


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

        public override async Task<MonthlyCSV> GetMonthlyReportAsCSV(DateGet request, ServerCallContext context)
        {
            _logger.LogInformation($"Requested CSV for month: {request.Month}, year: {request.Year}");

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

            List<string> csvRows = new List<string>
            {
                "Item Id, Item Name, Quantity Sold, Revenue"
            };

            while (await reader.ReadAsync())
            {
                csvRows.Add($"{reader.GetFieldValue<uint>(0)}, {reader.GetFieldValue<string>(1)}, {reader.GetFieldValue<float>(2)}, {reader.GetFieldValue<float>(3)}");
            }

            return (new MonthlyCSV
            {
                CsvRow = { csvRows }
            });
        }
    }    
}
