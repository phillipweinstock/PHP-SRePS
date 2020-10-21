using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PHP_SRePS_Frontend
{
    public partial class ReportMenu : Form
    {
        MainMenu menuForm;

        public ReportMenu(MainMenu form)
        {
            InitializeComponent();

            menuForm = form;
        }

        private void btnMonthly_Click(object sender, EventArgs e)
        {
            MonthlyReport mr = new MonthlyReport(this);
            mr.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            menuForm.Show();
            this.Close();
        }
    }
}
