using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Earth
{
    public partial class ShowUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rtpInfo.DataSource = MyData();
            rtpInfo.DataBind();
        }

        private DataTable MyData()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);

            string select = "SELECT * FROM Login";
            SqlCommand cmd = new SqlCommand(select, con);

            con.Open();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }
    }
}