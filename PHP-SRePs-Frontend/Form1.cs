using Grpc.Core;
using Grpc.Net.Client;
using PHP_SRePS_Backend;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHP_SRePS_Frontend
{
    public partial class Form1 : Form
    {
        GrpcChannel Channel;
        ItemDef.ItemDefClient client;
        public Form1()
        {
            InitializeComponent();

            Channel = GrpcChannel.ForAddress("https://localhost:5001");
            // _ = AddSaleExample();
            // _ = RequestSales();
        }

        /// <summary>
        /// Temporary: add a sale to the db
        /// </summary>
        private async Task AddSaleExample()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new SaleDef.SaleDefClient(channel);

            var input = new AddSaleRequest
            {
                // Send the list of item details
                ItemDetails = {
                    new AddSaleRequest.Types.ItemDetail { ItemName = "Car", Quantity = 3 }
                },
                TotalBilled = 200
            };

            var reply = await client.AddSaleAsync(input);

            lblTest.Text = "Done";
        }
        private async Task GetItemExampleAsync()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new ItemDef.ItemDefClient(channel);

            var input = new HasChanged
            {
                // Send the list of item details
                ChangedData = false
            };

            var s = new ItemGet
            {
                ItemId = 4
            };

            var reply = await client.GetItemAsync(s);
            lblTest.Text = reply.NameId;

            /*
            using (var call = client.GetAllItems(input))
            {
                while (await call.ResponseStream.MoveNext())
                {
                    var current = call.ResponseStream.Current;

                    lblTest.Text += current.NameId;
                }
            }*/

        }

        /// <summary>
        /// Temporary: request sale information.
        /// Using a date will get all sale information for that day.
        /// Using a sale id will get only that sale information.
        /// </summary>
        private async Task RequestSales()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new SaleDef.SaleDefClient(channel);

            // This should only have 1 field: 
            // not SaleId = num, SaleDate = "a date"
            var input = new SaleGet
            {
                SaleId = 1
            };

            // get the current sale information
            var currentSaleInfo = await client.GetSaleAsync(input);

            var totalBilled = currentSaleInfo.TotalBilled;

            // Get the item information
            foreach (var itemInfo in currentSaleInfo.ItemDetails)
            {
                // Do something with the item
                lblTest.Text = itemInfo.Name;

                await Task.Delay(1000);
            }
        }

        private async Task RequestAllSales()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new SaleDef.SaleDefClient(channel);

            var input = new HasChanged
            {
                // Send the list of item details
                ChangedData = false
            };

            // Recieving a stream:
            // each time MoveNext() is called, a new Sale will be returned
            using (var call = client.GetAllSales(input))
            {
                // while there are items in the stream
                while (await call.ResponseStream.MoveNext())
                {
                    // get the current sale information
                    var currentSaleInfo = call.ResponseStream.Current;

                    var totalBilled = currentSaleInfo.TotalBilled;

                    // Get the item information
                    foreach (var itemInfo in currentSaleInfo.ItemDetails)
                    {
                        // Do something with the item
                        //lblTest.Text = itemInfo.Name;
                    }

                    lblTest.Text += currentSaleInfo.SaleId.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ = RequestAllSales();

            //_ = RequestSales();
            //GetItemExampleAsync();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
