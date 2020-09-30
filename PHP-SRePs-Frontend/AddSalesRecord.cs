using Grpc.Core;
using Grpc.Net.Client;
using PHP_SRePS_Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHP_SRePS_Frontend
{
    public partial class AddSalesRecord : Form
    {
        MainMenu frmMainMenu;

        public AddSalesRecord(MainMenu form)
        {
            InitializeComponent();
            frmMainMenu = form;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //lblTest.Text = reply.Message;
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            salesRecordView.Rows.RemoveAt(salesRecordView.CurrentRow.Index);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddItem frmAddItem = new AddItem(this);
            frmAddItem.Show();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            //add record to db
            frmMainMenu.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainMenu.Show();
            this.Hide();
        }
    }
}
