using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grpc.Core;
using Grpc.Net.Client;
using PHP_SRePS_Backend;

namespace PHP_SRePS_Frontend
{
    class Gprc_channel_instance
    {

        public static GrpcChannel channel; //= GrpcChannel.ForAddress("https://localhost:5001");
        public static ItemDef.ItemDefClient ItemClient;
        public static CategoryDef.CategoryDefClient CategoryClient;
        public static ReportDef.ReportDefClient ReportClient;
        public static SaleDef.SaleDefClient SaleClient;
        public static StockDef.StockDefClient StockClient;
        private Gprc_channel_instance()
        {
            channel = GrpcChannel.ForAddress("https://localhost:5001");
        }
        private static Gprc_channel_instance _instance;
        public static Gprc_channel_instance GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Gprc_channel_instance();
                channel = GrpcChannel.ForAddress("https://localhost:5001");
                ItemClient = new ItemDef.ItemDefClient(channel);
                CategoryClient = new CategoryDef.CategoryDefClient(channel);
                ReportClient = new ReportDef.ReportDefClient(channel);
                SaleClient = new SaleDef.SaleDefClient(channel);
                StockClient = new StockDef.StockDefClient(channel);
            }
            return _instance;
        }
    }
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //new LogIn().Show();

            new MainMenu().Show();

            //new TestForm().Show();
            
            Application.Run();
        }
    }
}
