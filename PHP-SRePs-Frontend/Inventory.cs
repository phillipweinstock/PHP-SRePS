using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PHP_SRePS_Frontend
{
    public partial class Inventory : Form
    {
        CheckStock frmCheckStock;
        UpdateStock frmUpdateStock;
        RemoveStock frmRemoveStock;
        MainMenu frmMainMenu;

        public Inventory(MainMenu form)
        {
            InitializeComponent();
            frmMainMenu = form;
            frmCheckStock = new CheckStock(this);
            frmRemoveStock = new RemoveStock(this);
            frmUpdateStock = new UpdateStock(this);
        }

        private void btnCheckStock_Click(object sender, EventArgs e)
        {
            frmCheckStock.Show();
            this.Hide();
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            frmUpdateStock.Show();
            this.Hide();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            frmRemoveStock.Show();
            this.Close();
        }

        private void btnCreateItem_Click(object sender, EventArgs e)
        {
            AddStock frmAddStock = new AddStock();
            frmAddStock.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainMenu.Show();
            this.Close();
        }
    }
}
