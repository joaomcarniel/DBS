using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AnotherForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\college\AnotherForm\AnotherForm\Database.mdf;Integrated Security=True");


        private void gb_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboCounties.DataSource = Enum.GetValues(typeof(Counties));
        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fn = txtfn.Text;
            string sn = txtsn.Text;
            string cy = cboCounties.SelectedItem.ToString();
            string dob = dtpdob.Text;
            string ge = "Male";
            if (rbfemale.Checked)
                ge = "Female";

            string insert = "INSERT INTO student(firstName, surname, county, dateBirth, gender) " +
                "VALUES(@fn, @sn, @cy, @dob, @ge)";

            SqlCommand cmd = new SqlCommand(insert, con);
            cmd.Parameters.AddWithValue("@fn", fn);
            cmd.Parameters.AddWithValue("@sn", sn);
            cmd.Parameters.AddWithValue("@cy", cy);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@ge", ge);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            txtfn.Clear();
            txtsn.Clear();
        }
    }
}
