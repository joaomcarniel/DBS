using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Nature
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCon"].ConnectionString);
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;
            var email = txtEmail.Text;
            var comments = txtComments.Text;

            var insert = "INSERT INTO Contact(Name, Email, Comments) VALUES(@name, @email, @comments)";
            SqlCommand cmd = new SqlCommand(insert, con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@comments", comments);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            txtName.Text = "";
            txtEmail.Text = "";
            txtComments.Text = "";

            Response.Redirect("Default.aspx");
        }
    }
}