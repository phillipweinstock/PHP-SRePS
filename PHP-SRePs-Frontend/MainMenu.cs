using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PHP_SRePS_Frontend
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogIn frmLogIn = new LogIn();
            frmLogIn.Show();
            this.Close();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            SaleMenu sm = new SaleMenu(this);
            sm.Show();
            this.Hide();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            StockMenu sm = new StockMenu(this);
            sm.Show();
            this.Hide();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportMenu sm = new ReportMenu(this);
            sm.Show();
            this.Hide();
        }
    }
}
