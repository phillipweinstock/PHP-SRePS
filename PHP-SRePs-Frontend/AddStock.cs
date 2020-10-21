using Grpc.Net.Client;
using PHP_SRePS_Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHP_SRePS_Frontend
{
    public partial class AddStock : Form
    {
        public AddStock()
        {
            
            InitializeComponent();
            _ = Gprc_channel_instance.GetInstance();
        }

        private async void btnAddStock_Click(object sender, EventArgs e)
        {
            //add item to database

            var txtCat = this.txtCategory;
            var txtName = this.txtName;
            var txtPrice = this.txtPrice;
            var txtQuant = this.txtQuantity;

            var catid = 1u;

            if(txtName.Text != "" && txtPrice.Text != "" && txtQuant.Text != "")
            {
                if(txtCat.Text != "")
                {
                    catid = uint.Parse(txtCat.Text.Trim());
                }

                await AddItem(catid, txtName.Text.Trim(), float.Parse(txtPrice.Text.Trim(), CultureInfo.InvariantCulture), int.Parse(txtQuant.Text.Trim()));
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task AddItem(uint categoryid, string name, float price, int quantity)
        {

            var client = Gprc_channel_instance.ItemClient;

            var input = new Item
            {
                ItemId = 0,
                CatagoryId = categoryid,
                NameId = name,
                PriceId = price
            };

            await client.AddItemAsync(input);

            var getId = new ItemGet
            {
                NameId = name
            };

            var reply = await client.GetItemAsync(getId);

            var itemid = reply.ItemId;

            var stockClient = Gprc_channel_instance.StockClient;

            var addStock = new StockTake
            {
                Item = new Item { ItemId = itemid },
                Info = new StockInfo { Stock = quantity}
            };

            await stockClient.AddStockAsync(addStock);

        }
    }
}
