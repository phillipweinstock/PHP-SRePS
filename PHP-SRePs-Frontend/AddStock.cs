using System;
﻿using Grpc.Net.Client;
using PHP_SRePS_Backend;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHP_SRePS_Frontend
{
    public partial class AddStock : Form
    {
        public AddStock()
        {
            InitializeComponent();
        }

        private async void btnAddStock_Click(object sender, EventArgs e)
        {
            //add item to database

            var txtCat = this.txtCategory;
            var txtName = this.txtName;
            var txtPrice = this.txtPrice;
            var txtQuant = this.txtQuantity;

            await AddItem(UInt32.Parse(txtCat.Text.Trim()), txtName.Text.Trim(), float.Parse(txtPrice.Text.Trim(), CultureInfo.InvariantCulture));

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task AddItem(uint categoryid, string name, float price)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new ItemDef.ItemDefClient(channel);

            var input = new Item
            {
                ItemId = 0,
                CatagoryId = categoryid,
                NameId = name,
                PriceId = price
            };

            var reply = await client.AddItemAsync(input);
        }
    }
}
