using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PHP_SRePS_Frontend
{
    public partial class CheckStock : Form
    {
        MainMenu frmMainMenu = new MainMenu();

        public CheckStock()
        {
            InitializeComponent();
        }

        private void CheckStock_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainMenu.Show();
            this.Hide();
        }
    }
}
