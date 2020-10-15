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
            this.txtItemID.TextChanged += txtItemID_TextChanged;
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

        private void txtItemID_TextChanged(object sender, EventArgs e)
        {
            bool enteredLetter = false;
            Queue<char> text = new Queue<char>();
            foreach (var ch in this.txtItemID.Text)
            {
                if (char.IsDigit(ch))
                {
                    text.Enqueue(ch);
                }
                else
                {
                    enteredLetter = true;
                }
            }

            if (enteredLetter)
            {
                StringBuilder sb = new StringBuilder();
                while (text.Count > 0)
                {
                    sb.Append(text.Dequeue());
                }

                this.txtItemID.Text = sb.ToString();
                this.txtItemID.SelectionStart = this.txtItemID.Text.Length;
            }
        }
    }
}
