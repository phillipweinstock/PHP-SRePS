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
        MainMenu frmMainMenu;

        public Inventory(MainMenu form)
        {
            InitializeComponent();
            frmMainMenu = form;
        }

        private void btnCheckStock_Click(object sender, EventArgs e)
        {
            CheckStock frmCheckStock = new CheckStock(this);
            frmCheckStock.Show();
            this.Hide();
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            UpdateStock frmUpdateStock = new UpdateStock(this);
            frmUpdateStock.Show();
            this.Hide();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            RemoveStock frmRemoveStock = new RemoveStock(this);
            frmRemoveStock.Show();
            this.Hide();
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
