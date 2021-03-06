﻿using Grpc.Core;
using Grpc.Net.Client;
using PHP_SRePS_Backend;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHP_SRePS_Frontend
{
    public partial class MonthlyReport : Form
    {
        ReportMenu menuForm;

        public MonthlyReport(ReportMenu form)
        {
            _ = Gprc_channel_instance.GetInstance();
            InitializeComponent();

            menuForm = form;
        }

        private async void btnGenerateReport_Click(object sender, EventArgs e)
        {
            await getMonthlySale();
        }

        private async Task getMonthlySale()
        {

            var client = Gprc_channel_instance.ReportClient;

            var input = new DateGet
            {
                Month = Int32.Parse(txtMonth.Text),
                Year = Int32.Parse(txtYear.Text)
            };

            var dvg = dvgSalesReport;



            using(var call = client.GetMonthlyReport(input))
            {
                var total = 0f;

                while (await call.ResponseStream.MoveNext())
                {
                    var currentItemInfo = call.ResponseStream.Current;


                    var itemid = currentItemInfo.ItemId;
                    var itemName = currentItemInfo.ItemName;
                    var qty = currentItemInfo.QtySold;
                    var revenue = currentItemInfo.ItemRevenue;

                    total += revenue;

                    dvg.Rows.Add(itemid, itemName, qty, revenue);
                }

                lblTotalPrice.Text = $"${total:0.00}";
            }
        }

        private async void btnCSV_Click(object sender, EventArgs e)
        {
            var client = Gprc_channel_instance.ReportClient;

            var input = new DateGet
            {
                Month = Int32.Parse(txtMonth.Text),
                Year = Int32.Parse(txtYear.Text)
            };

            var csvInfo = await client.GetMonthlyReportAsCSVAsync(input);


            using (var w = new StreamWriter($".\\sale-report-{txtMonth.Text}-{txtYear.Text}.csv"))
            {
                foreach (var r in csvInfo.CsvRow)
                {
                    w.WriteLine(r);
                    w.Flush();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            menuForm.Show();
            this.Close();
        }
    }
}
