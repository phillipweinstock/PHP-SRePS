using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PHP_SRePS_Frontend
{
    public partial class SaleMenu : Form
    {
        MainMenu formMain;

        public SaleMenu(MainMenu form)
        {
            InitializeComponent();

            formMain = form;
        }

        private void btnAddSales_Click(object sender, EventArgs e)
        {
            AddSalesRecord asr = new AddSalesRecord(this);
            asr.Show();
            this.Hide();
        }

        private void btnCheckSales_Click(object sender, EventArgs e)
        {
            CheckSales cs = new CheckSales(this);
            cs.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formMain.Show();
            this.Close();
        }
    }
}
