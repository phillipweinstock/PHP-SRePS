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

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            AddSalesRecord frmAddSalesRecord = new AddSalesRecord(this);
            frmAddSalesRecord.Show();
            this.Hide();
        }
        private void btnCheckStock_Click(object sender, EventArgs e)
        {
            Inventory frmInventory = new Inventory(this);
            frmInventory.Show();
            this.Hide();
        }
        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            CheckSales frmCheckSales = new CheckSales(this);
            frmCheckSales.Show();
            this.Hide();
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogIn frmLogIn = new LogIn();
            frmLogIn.Show();
            this.Close();
        }

        
    }
}
