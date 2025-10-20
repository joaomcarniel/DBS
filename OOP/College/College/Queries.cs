using System.Data;
using System.Data.SqlClient;

namespace College
{
    internal class Queries
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\college\OOP\College\College\CollegeDatabase.mdf;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt;

        public DataTable ShowStudents()
        {
            con.Open();
            da = new SqlDataAdapter();
            dt = new DataTable();

            string select = "SELECT * FROM Student;";

            SqlCommand cmd = new SqlCommand(select, con);

            da.SelectCommand = cmd;

            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable ShowLecturers()
        {
            con.Open();
            da = new SqlDataAdapter();
            dt = new DataTable();

            string select = "SELECT * FROM Lecturer;";

            SqlCommand cmd = new SqlCommand(select, con);

            da.SelectCommand = cmd;

            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable ShowGender(string gen)
        {
            con.Open();
            da = new SqlDataAdapter();
            dt = new DataTable();

            string select = "SELECT * FROM Student WHERE gender = @gen;";
            SqlCommand cmd = new SqlCommand(select, con);
            cmd.Parameters.AddWithValue("@gen", gen);

            da.SelectCommand = cmd;

            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable ShowStudentCounty(string county)
        {
            con.Open();
            da = new SqlDataAdapter();
            dt = new DataTable();

            string select = "SELECT * FROM Student WHERE County = @county;";
            SqlCommand cmd = new SqlCommand(select, con);
            cmd.Parameters.AddWithValue("@county", county);

            da.SelectCommand = cmd;

            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
