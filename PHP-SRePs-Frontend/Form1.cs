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

namespace PHP_SRePS_Frontend
{
    public partial class Home : Form
    {
        int lastRow = 0; //store index of last row

        public Home()
        {
            InitializeComponent();
            //_ = RpcTest();

        }

        //Rpc test example
        /*private async Task RpcTest()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);

            var input = new PHP_SRePS_Backend.HelloRequest { Name = "Bruh" };

            var reply = await client.SayHelloAsync(input);

            lblTest.Text = reply.Message;
        }*/

        

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            //Add textbox data to the list
            salesRecordView.Rows.Add();

            salesRecordView.Rows[lastRow].Cells[0].Value = itmIDTxt.Text;
            itmIDTxt.Text = "";
            salesRecordView.Rows[lastRow].Cells[1].Value = itmName.Text;
            itmName.Text = "";
            salesRecordView.Rows[lastRow].Cells[2].Value = price.Text;
            price.Text = "";
            salesRecordView.Rows[lastRow].Cells[3].Value = amtSold.Text;
            amtSold.Text = "";

            lastRow++;
        }

        private void removeItemBtn_Click(object sender, EventArgs e)
        {
            salesRecordView.Rows.RemoveAt(salesRecordView.CurrentRow.Index);
        }
    }
}
