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
            InitializeComponent();
            frmInventory = form;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmInventory.Show();
            this.Close();
        }

        private async void btnRemove_Click(object sender, EventArgs e)
        {
            var txtName = this.txtName;
            var txtId = this.txtId;

            if(txtName.Text != "")
            {
                await RemoveItem(txtName.Text.Trim());
            } else
            {
                await RemoveItem(id: uint.Parse(txtId.Text.Trim()));
            }
        }

        private async Task RemoveItem(string name = "", uint id = 0)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new ItemDef.ItemDefClient(channel);

            var input = new Item
            {
                ItemId = id,
                NameId = name
            };

            var reply = await client.DeleteItemAsync(input);
        }
    }
}
