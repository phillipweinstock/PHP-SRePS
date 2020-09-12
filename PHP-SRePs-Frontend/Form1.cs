using Grpc.Net.Client;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            /*_ = RpcTest();*/
        }

        //Rpc test example
/*        private async Task RpcTest()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Sale.SaleClient(channel);

            var input = new AddSaleRequest { Name = "Bruh" };

            var reply = await client.SayHelloAsync(input);

            lblTest.Text = reply.Message;
        }*/
    }
}
