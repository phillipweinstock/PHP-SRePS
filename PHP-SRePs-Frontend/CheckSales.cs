using Grpc.Core;
using Grpc.Net.Client;
using PHP_SRePS_Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PHP_SRePS_Backend.SaleInfo.Types;

namespace PHP_SRePS_Frontend
{
    public partial class CheckSales : Form
    {
        SaleMenu formMenu;

        public CheckSales(SaleMenu form)
        {
            InitializeComponent();
            formMenu = form;

            _ = Gprc_channel_instance.GetInstance();
        }

        private async void CheckSales_Load(object sender, EventArgs e)
        {
            await GetAllSales();
        }

        private async Task GetAllSales()
        {
            var client = Gprc_channel_instance.SaleClient;

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

                    dvg.Rows.Add(current, saleid, total);                    

                    current++;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formMenu.Show();
            this.Close();
        }

        private async void dgvSalesSearch_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvSalesSearch.SelectedRows.Count > 0)
                {
                    var dvg = this.dgvSalesSearch;

                    var client = Gprc_channel_instance.SaleClient;

                    // This should only have 1 field: 
                    // not SaleId = num, SaleDate = "a date"                      
                    var input = new SaleGet
                    {
                        SaleId = uint.Parse(dvg.SelectedRows[0].Cells[1].Value.ToString())
                    };

                    // get the current sale information
                    var currentSaleInfo = await client.GetSaleAsync(input);

                    var dvgItems = this.dvgItemInfo;
                    dvgItems.Rows.Clear();

                    // Get the item information
                    foreach (var itemInfo in currentSaleInfo.ItemDetails)
                    {
                        dvgItems.Rows.Add(itemInfo.ItemId, itemInfo.Name, itemInfo.Price, itemInfo.Quantity);
                    }

                    dvgItems.Refresh();
                }
            } catch { }
        }
    }
}
