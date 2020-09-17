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
    public partial class Home : Form
    {
        int lastRow = 0; //store index of last row

        public Home()
        {
            InitializeComponent();
            //_ = RpcTest();

<<<<<<< HEAD
        }

        //Rpc test example
        /*private async Task RpcTest()
=======
           // _ = AddSaleExample();
           // _ = RequestSales();
        }

        /// <summary>
        /// Temporary: add a sale to the db
        /// </summary>
        private async Task AddSaleExample()
>>>>>>> 95a951932999768fa22bbc1bc9efeacefa805d66
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

            lblTest.Text = "Done";
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

            lblTest.Text = reply.ItemList_.Count.ToString();

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
                        lblTest.Text = itemInfo.Name;
                    }
                }
            }

            lblTest.Text = "Done";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ = GetItemExample();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

<<<<<<< HEAD
            lblTest.Text = reply.Message;
        }*/

        

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            //Add textbox data to the list
            salesRecordView.Rows.Add();

            salesRecordView.Rows[lastRow].Cells[0].Value = itmIDTxt.Text;
            itmIDTxt.Text = "";
            salesRecordView.Rows[lastRow].Cells[1].Value = itmName.Text;
            itmName.Text = "";
            salesRecordView.Rows[lastRow].Cells[2].Value = price.Text;
            price.Text = "";
            salesRecordView.Rows[lastRow].Cells[3].Value = amtSold.Text;
            amtSold.Text = "";

            lastRow++;
        }

        private void removeItemBtn_Click(object sender, EventArgs e)
        {
            salesRecordView.Rows.RemoveAt(salesRecordView.CurrentRow.Index);
=======
>>>>>>> 95a951932999768fa22bbc1bc9efeacefa805d66
        }
    }
}
