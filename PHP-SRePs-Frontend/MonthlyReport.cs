using Grpc.Core;
using Grpc.Net.Client;
using PHP_SRePS_Backend;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHP_SRePS_Frontend
{
    public partial class MonthlyReport : Form
    {
        public MonthlyReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
=======
        private async void btnGenerateReport_Click(object sender, EventArgs e)
        {
            await getMonthlySale();
        }

        private async Task getMonthlySale()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new ReportDef.ReportDefClient(channel);

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

                lblTotalPrice.Text = $"${total}";
            }
        }

>>>>>>> 2198bdf97efd5a9e400c94e288bb8afab187c0fc
    }
}
