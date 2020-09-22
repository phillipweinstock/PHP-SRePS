using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PHP_SRePS_Frontend
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //add item values to the db, item ID is generated there
            this.Close();
        }
    }
}
