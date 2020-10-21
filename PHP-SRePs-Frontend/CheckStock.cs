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
    public partial class CheckStock : Form
    {
        StockMenu frmInventory;

        public CheckStock(StockMenu form)
        {
            InitializeComponent();
            _ = Gprc_channel_instance.GetInstance();
            frmInventory = form;
        }

        private async void CheckStock_Load(object sender, EventArgs e)
        {
            await GetAllItems();
        }

        private async Task GetAllItems()
        {
            var client = Gprc_channel_instance.ItemClient;

            var input = new HasChanged
            {
                // Send the list of item details
                ChangedData = false
            };

            var dvg = this.dgvStockSearch;

            // Recieving a stream:
            // each time MoveNext() is called, a new Sale will be returned
            using (var call = client.GetAllItems(input))
            {
                int current = 1;
                // while there are items in the stream
                while (await call.ResponseStream.MoveNext())
                {
                    // get the current sale information
                    var currentSaleInfo = call.ResponseStream.Current;

                    var catid = currentSaleInfo.CatagoryId;
                    var itemid = currentSaleInfo.ItemId;
                    var name = currentSaleInfo.NameId;
                    var price = currentSaleInfo.PriceId;

                    // Get the stock for the item
                    var stockClient = Gprc_channel_instance.StockClient;

                    var itemIn = new Item
                    {
                        ItemId = itemid
                    };

                    var available = await stockClient.GetStockAsync(itemIn);

                    dvg.Rows.Add(current.ToString(), itemid, name, price, available.Stock, catid);                    

                    current++;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmInventory.Show();
            this.Close();
        }
    }
}
