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
        AddStock frmAddStock;
        MainMenu frmMainMenu;

        public Inventory(MainMenu form)
        {
            InitializeComponent();
            frmMainMenu = form;
            frmCheckStock = new CheckStock(this);
            frmRemoveStock = new RemoveStock(this);
            frmUpdateStock = new UpdateStock(this);
            frmAddStock = new AddStock();
        }

        private void btnCheckStock_Click(object sender, EventArgs e)
        {
            frmCheckStock.Show();
            this.Close();
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            frmUpdateStock.Show();
            this.Close();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            frmRemoveStock.Show();
            this.Close();
        }

        private void btnCreateItem_Click(object sender, EventArgs e)
        {
            frmAddStock.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainMenu.Show();
            this.Close();
        }
    }
}
