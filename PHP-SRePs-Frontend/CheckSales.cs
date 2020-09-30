using Grpc.Core;
using Grpc.Net.Client;
using PHP_SRePS_Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHP_SRePS_Frontend
{
    public partial class CheckSales : Form
    {
        MainMenu frmMainMenu;

        public CheckSales(MainMenu form)
        {
            InitializeComponent();
            frmMainMenu = form;
        }

        private async void CheckSales_Load(object sender, EventArgs e)
        {
            await GetAllSales();
        }

        private async Task GetAllSales()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new SaleDef.SaleDefClient(channel);

            var input = new HasChanged
            {
                // Send the list of item details
                ChangedData = false
            };


            var dvg = this.dgvSalesSearch;

            // Recieving a stream:
            // each time MoveNext() is called, a new Sale will be returned
            using (var call = client.GetAllSales(input))
            {
                int current = 1;
                // while there are items in the stream
                while (await call.ResponseStream.MoveNext())
                {
                    // get the current sale information
                    var currentSaleInfo = call.ResponseStream.Current;

                    var saleid = currentSaleInfo.SaleId;
                    var total = currentSaleInfo.TotalBilled;

                    // Get the item information
                    foreach (var itemInfo in currentSaleInfo.ItemDetails)
                    {
                        // Do something with the item
                        //lblTest.Text = itemInfo.Name;
                    }

                    dvg.Rows.Add(current, saleid, total);                    

                    current++;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainMenu.Show();
            this.Close();
        }
    }
}
