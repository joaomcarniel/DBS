using System.Data.SqlClient;

namespace College
{
    internal class Lecturer : Staff 
    {
        public string Modules { get; set; }

        public Lecturer(string fn, string sn, string cy, string dob, string ge, string mod, decimal pay)
            :base(fn, sn, cy, dob, ge, pay)
        {
            Modules = mod;
            Pay = pay;
        }

        public void AddLecturer()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\college\OOP\College\College\CollegeDatabase.mdf;Integrated Security=True");
            var insert = "INSERT INTO Lecturer(FirstName, Surname, County, DOB, Gender, Modules, Pay) VALUES(@fn, @sn, @cy, @dob, @ge, @modules, @pay)";
            SqlCommand cmd = new SqlCommand(insert, con);
            cmd.Parameters.AddWithValue("@fn", FirstName);
            cmd.Parameters.AddWithValue("@sn", LastName);
            cmd.Parameters.AddWithValue("@cy", County);
            cmd.Parameters.AddWithValue("@dob", DoB);
            cmd.Parameters.AddWithValue("@ge", Gender);
            cmd.Parameters.AddWithValue("@Modules", Modules);
            cmd.Parameters.AddWithValue("@Pay", Pay);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
