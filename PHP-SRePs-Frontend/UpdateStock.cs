using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PHP_SRePS_Frontend
{
    public partial class UpdateStock : Form
    {
        StockMenu frmInventory;
        AddStock frmAddStock;

        public UpdateStock(StockMenu form)
        {
            InitializeComponent();
            frmInventory = form;
            frmAddStock = new AddStock();
            frmAddStock.Name = "Update Stock";
            frmAddStock.btnAddStock.Text = "Save";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmAddStock.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmInventory.Show();
            this.Close();
        }
    }
}
