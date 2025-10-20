using System;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var userName = "admin";
            var password = "bandit";

            var user = txtUser.Text;
            var pass = txtPass.Text;

            if(userName == user)
            {
                if(password == pass)
                {
                    lblDisplay.Text = "You are logged in";
                }
                else
                {
                    lblDisplay.Text = "Wrong password";
                }
            }
            else
            {
                lblDisplay.Text = "Wrong userName";
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }
    }
}
