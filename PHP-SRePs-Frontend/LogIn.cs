using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PHP_SRePS_Frontend
{
    public partial class LogIn : Form
    {
        MainMenu frmMainMenu = new MainMenu();

        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //check user Id and password against database or w/e
          
            string mssg = "Username and/or Password is incorrect";
            if (txtUsername.Text == "Admin" && txtPassword.Text =="LEGENDARY")
            {
                frmMainMenu.Show();
                this.Close();
            }
            else
            {
                label4.Text = mssg;
            }
           
            
        }
    }
}
