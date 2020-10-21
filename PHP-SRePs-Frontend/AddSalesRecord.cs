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
using System.Runtime.InteropServices;
using static PHP_SRePS_Backend.SaleInfo.Types;

namespace PHP_SRePS_Frontend
{
    public partial class AddSalesRecord : Form
    {
        SaleMenu formMenu;

        public AddSalesRecord(SaleMenu form)
        {
            InitializeComponent();
            formMenu = form;
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                salesRecordView.Rows.RemoveAt(salesRecordView.CurrentRow.Index);
            } catch { }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddItem frmAddItem = new AddItem(this);
            frmAddItem.Show();
        }

        private async void btnContinue_Click(object sender, EventArgs e)
        {
            //add record to db
            var salesDataView = this.salesRecordView;

            List<ItemDetail> itemInfos = new List<ItemDetail>();
            foreach (DataGridViewRow row in salesDataView.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[2].Value != null) {
                    var itemname = row.Cells[1].Value.ToString().Trim();
                    var quantity = UInt32.Parse(row.Cells[2].Value.ToString().Trim());

                    /*
                     * Item id = 0
                     * Item name = 1
                     * quantity = 2
                     * price = 3
                     */


                    if (itemname != "")
                    {
                        itemInfos.Add(new ItemDetail
                        {
                            ItemName = itemname,
                            Quantity = quantity
                        });
                    }
                }
            }

            if (itemInfos.Count > 0)
            {
                await AddSale(itemInfos);
            }

            formMenu.Show();
            this.Close();
        }

        private async Task AddSale(List<ItemDetail> itemInfos)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new SaleDef.SaleDefClient(channel);

            var input = new AddSaleRequest
            {
                // Send the list of item details
                ItemDetails = { itemInfos }
            };

            var reply = await client.AddSaleAsync(input);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formMenu.Show();
            this.Close();
        }

        public async Task AddItem(string itemName)
        {
            var dvg = this.salesRecordView;

            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new ItemDef.ItemDefClient(channel);

            var input = new ItemGet
            {
                NameId = itemName
            };

            var reply = await client.GetItemAsync(input);


            dvg.Rows.Add(reply.ItemId, reply.NameId, "", reply.PriceId);
        }

    }
}
