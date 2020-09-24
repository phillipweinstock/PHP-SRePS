using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PHP_SRePS_Frontend
{
    public partial class grpcForm : Form
    {
        public grpcForm()
        {
            InitializeComponent();
        }

        private void btnSaveTest_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
