using Grpc.Net.Client;
using PHP_SRePS_Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHP_SRePS_Frontend
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();

            AllocConsole();
            toCsvFile();
            //getMonthlySale();           
            //alter_sale();
            //Test();
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        // Purely for testing
        private async Task toCsvFile()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new ReportDef.ReportDefClient(channel);

            var input = new DateGet
            {
                Month = 10,
                Year = 2020
            };

            var csvInfo = await client.GetMonthlyReportAsCSVAsync(input);


            using (var w = new StreamWriter(".\\test.csv"))
            {
                foreach (var r in csvInfo.CsvRow)
                {
                    Console.WriteLine(r);
                    w.WriteLine(r);
                    w.Flush();
                }
            }
        }

        /*
        private async Task getMonthlySale()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new ReportDef.ReportDefClient(channel);


            var input = new DateGet
            {
                Month = 10,
                Year = 2020
            };

            using (var call = client.GetMonthlyReport(input))
            {
                var current = 1;
                // while there are items in the stream
                while (await call.ResponseStream.MoveNext())
                {
                    // get the current sale information
                    var currentItemInfo = call.ResponseStream.Current;

                    Console.WriteLine("\nCall: " + current);
                    Console.WriteLine($"Item ID: {currentItemInfo.ItemId}");
                    Console.WriteLine($"Item name: {currentItemInfo.ItemName}");
                    Console.WriteLine($"Quantity: {currentItemInfo.QtySold}");
                    Console.WriteLine($"Revenue: {currentItemInfo.ItemRevenue}");

                    current++;
                }
            }
        }

        /*
        private async Task alter_sale()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new SaleDef.SaleDefClient(channel);

            List<ItemDetail> itemInfos = new List<ItemDetail>();

            itemInfos.Add(new ItemDetail
            {
                ItemName = "Test",
                Quantity = 10
            });

            itemInfos.Add(new ItemDetail
            {
                ItemName = "Car",
                Quantity = 5
            });

            var input = new EditSaleRequest
            {
                SaleId = 3,
                ItemDetails = { itemInfos }
            };

            var currentSaleInfo = await client.AlterSaleAsync(input);
        }

        /*
        private async Task delete_sale()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new SaleDef.SaleDefClient(channel);

            // This should only have 1 field: 
            // not SaleId = num, SaleDate = "a date"
            var input = new SaleGet
            {
                SaleId = 2
            };

            // get the current sale information
            var currentSaleInfo = await client.DeleteSaleAsync(input);
        }
        */
    }
}
