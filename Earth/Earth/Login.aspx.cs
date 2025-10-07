using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Earth
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            string pass2 = txtPass2.Text;
            if (IsPostBack)
            {
                if (pass == pass2)
                {
                    AddUser(user, pass);
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    lblDisplay.Text = "Passwords do not match";
                    txtPass.Text = "";
                    txtPass2.Text = "";
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

        }

        void AddUser(string user, string password)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);

            string insert = "Insert INTO Login(UserName, Password) VALUES(@user, @password)";
            SqlCommand cmd = new SqlCommand(insert, con);
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@password", password);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}