using Grpc.Core;
using Grpc.Net.Client;
using PHP_SRePS_Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHP_SRePS_Frontend
{
    public partial class AddSalesRecord : Form
    {
        AddItem frmAddItem = new AddItem();

        public AddSalesRecord()
        {
            InitializeComponent();
            _ = RpcTest();
        }

        //Rpc test example
        private async Task RpcTest() {
           _ = AddSaleExample();
           _ = RequestSales();
        }

        /// <summary>
        /// Temporary: add a sale to the db
        /// </summary>
        private async Task AddSaleExample()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new SaleDef.SaleDefClient(channel);

            var input = new AddSaleRequest {
                // Send the list of item details
                ItemDetails = { 
                    new AddSaleRequest.Types.ItemDetail { ItemId = 1, Quantity = 2 }, 
                    new AddSaleRequest.Types.ItemDetail { ItemId = 500, Quantity = 10000 } 
                },
                TotalBilled = 200
            };

            var reply = await client.AddSaleAsync(input);

            //lblTest.Text = "Done";
        }
        private async Task GetItemExample()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new ItemDef.ItemDefClient(channel);

            var input = new HasChanged
            {
                // Send the list of item details
                ChangedData = false
            };

            var reply = await client.GetAllItemsAsync(input);

            //lblTest.Text = reply.ItemList_.Count.ToString();

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

            // Recieving a stream:
            // each time MoveNext() is called, a new Sale will be returned
            using (var call = client.GetSale(input)) 
            {
                // while there are items in the stream
                while (await call.ResponseStream.MoveNext())
                {
                    // get the current sale information
                    var currentSaleInfo = call.ResponseStream.Current;

                    _ = currentSaleInfo.TotalBilled;

                    // Get the item information
                    foreach(var itemInfo in currentSaleInfo.ItemDetails)
                    {
                        // Do something with the item
                        //lblTest.Text = itemInfo.Name;
                    }
                }
            }

            //lblTest.Text = "Done";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            _ = GetItemExample();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //lblTest.Text = reply.Message;
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            salesRecordView.Rows.RemoveAt(salesRecordView.CurrentRow.Index);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            frmAddItem.Show();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            //add record to db
            this.Close();
        }
    }
}
