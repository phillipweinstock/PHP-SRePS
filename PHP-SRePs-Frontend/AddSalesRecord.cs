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
        AddItem frmAddItem;
        MainMenu frmMainMenu;

        public AddSalesRecord(MainMenu form)
        {
            InitializeComponent();
            frmAddItem = new AddItem(this);
            frmMainMenu = form;
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

        private async void btnContinue_Click(object sender, EventArgs e)
        {
            //add record to db
            var salesDataView = this.salesRecordView;

            List<ItemDetail> itemInfos = new List<ItemDetail>();
            foreach (DataGridViewRow row in salesDataView.Rows)
            {
                if (row.Cells[2].Value != null && row.Cells[3].Value != null) {
                    var itemname = row.Cells[2].Value.ToString().Trim();
                    var quantity = UInt32.Parse(row.Cells[3].Value.ToString().Trim());

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

            frmMainMenu.Show();
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
            frmMainMenu.Show();
            this.Close();
        }

        private void AddSalesRecord_Load(object sender, EventArgs e)
        {
            // Lines after this are for creating a console
            //AllocConsole();
        }

        /*
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();*/
    }
}
