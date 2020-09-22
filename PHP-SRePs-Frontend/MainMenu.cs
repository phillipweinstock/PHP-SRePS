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
        LogIn frmLogIn = new LogIn();
        AddSalesRecord frmAddSalesRecord = new AddSalesRecord();

        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            frmAddSalesRecord.Show();
            this.Hide();
        }
        private void btnCheckStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            //frmCheckStock.Show();
        }
        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            this.Hide();
            //frmAnalysis.Show();
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogIn.Show();
        }

        
    }
}
