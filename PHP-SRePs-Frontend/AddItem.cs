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
        AddSalesRecord frmAddSalesRecord;

        public AddItem(AddSalesRecord form)
        {
            InitializeComponent();

            frmAddSalesRecord = form;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //add item to bill
            txtItemID.Text = "";
            txtItemName.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
