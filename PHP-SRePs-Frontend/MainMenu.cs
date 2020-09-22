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
        LogIn frmLogIn;
        AddSalesRecord frmAddSalesRecord;
        Inventory frmInventory;

        public MainMenu()
        {
            InitializeComponent();
            frmAddSalesRecord = new AddSalesRecord(this);
            frmInventory = new Inventory(this);
        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            frmAddSalesRecord.Show();
            this.Close();
        }
        private void btnCheckStock_Click(object sender, EventArgs e)
        {
            this.Close();
            frmInventory.Show();
        }
        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            this.Close();
            //frmAnalysis.Show();
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogIn.Show();
        }

        
    }
}
