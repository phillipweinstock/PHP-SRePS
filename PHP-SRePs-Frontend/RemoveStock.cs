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
    public partial class RemoveStock : Form
    {
        StockMenu frmInventory;

        public RemoveStock(StockMenu form)
        {
            _ = Gprc_channel_instance.GetInstance();
            InitializeComponent();
            frmInventory = form;

            GetAllItems();
        }


        private async Task GetAllItems()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new ItemDef.ItemDefClient(channel);

            var input = new HasChanged
            {
                // Send the list of item details
                ChangedData = false
            };

            var dvg = dvgItems;

            // Recieving a stream:
            // each time MoveNext() is called, a new Sale will be returned
            using (var call = client.GetAllItems(input))
            {
                // while there are items in the stream
                while (await call.ResponseStream.MoveNext())
                {
                    // get the current sale information
                    var currentSaleInfo = call.ResponseStream.Current;

                    var catid = currentSaleInfo.CatagoryId;
                    var itemid = currentSaleInfo.ItemId;
                    var name = currentSaleInfo.NameId;
                    var price = currentSaleInfo.PriceId;

                    dvg.Rows.Add(itemid, name);
                }
            }
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            frmInventory.Show();
            this.Close();
        }

        private async void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                var itemid = dvgItems.CurrentRow.Cells[0].Value.ToString();

                await RemoveItem(uint.Parse(itemid));

                dvgItems.Rows.RemoveAt(dvgItems.CurrentRow.Index);
            } catch { }
        }

        private async Task RemoveItem(uint id)
        {

            var client = Gprc_channel_instance.ItemClient;

            var input = new Item
            {
                ItemId = id
            };

            var reply = await client.DeleteItemAsync(input);
        }
    }
}
