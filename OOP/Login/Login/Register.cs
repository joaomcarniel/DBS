using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\college\OOP\Login\Login\LoginDatabase.mdf;Integrated Security=True");
        HashCode hashCode = new HashCode();

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var fullName = txtFullName.Text;
            var userName = txtUserName.Text;
            var password = hashCode.PassHash(txtPass.Text);
            var insert = "INSERT INTO Login(FullName, UserName, Password) VALUES (@fullName, @userName, @password)";

            SqlCommand cmd = new SqlCommand(insert, con);
            cmd.Parameters.AddWithValue("@fullName", fullName);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@password", password);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            txtFullName.Clear();
            txtUserName.Clear();
            txtPass.Clear();

            this.Close();
        }
    }
}
