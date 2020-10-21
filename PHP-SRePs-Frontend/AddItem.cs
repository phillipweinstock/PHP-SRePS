using Grpc.Core;
using Grpc.Net.Client;
using PHP_SRePS_Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHP_SRePS_Frontend
{
    public partial class AddItem : Form
    {
        AddSalesRecord frmAddSalesRecord;

        public AddItem(AddSalesRecord form)
        {
            InitializeComponent();

            frmAddSalesRecord = form;

            DisplayAllItems();
        }

        private async Task DisplayAllItems()
        {

            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new ItemDef.ItemDefClient(channel);

            var input = new HasChanged
            {
                // Send the list of item details
                ChangedData = false
            };

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

                    lbItems.Items.Add(name);
                }
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            frmAddSalesRecord.AddItem(lbItems.SelectedItem.ToString());
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
