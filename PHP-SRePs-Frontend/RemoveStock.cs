using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PHP_SRePS_Frontend
{
    public partial class RemoveStock : Form
    {
        Inventory frmInventory;

        public RemoveStock(Inventory form)
        {
            InitializeComponent();
            frmInventory = form;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmInventory.Show();
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
