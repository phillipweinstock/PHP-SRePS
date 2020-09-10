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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            _ = RpcTest();
        }

        //Rpc test example
        private async Task RpcTest()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);

            var input = new PHP_SRePS_Backend.HelloRequest { Name = "Bruh" };

            var reply = await client.SayHelloAsync(input);

            lblTest.Text = reply.Message;
        }
    }
}
