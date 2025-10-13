using System.Data.SqlClient;

namespace College
{
    internal class Student : Person
    {
        public int StuNum { get; set; }
        
        public Student(string fn, string sn, string cy, string dob, string ge, int stuNum)
            :base(fn, sn, cy, dob, ge)
        {
            StuNum = stuNum;
        }

        public void AddStudent()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\college\OOP\College\College\CollegeDatabase.mdf;Integrated Security=True");
            var insert = "INSERT INTO Student(FirstName, Surname, County, DOB, Gender, StudentNum) VALUES(@fn, @sn, @cy, @dob, @ge, @stuNum)";
            SqlCommand cmd = new SqlCommand(insert, con);
            cmd.Parameters.AddWithValue("@fn",FirstName);
            cmd.Parameters.AddWithValue("@sn",LastName);
            cmd.Parameters.AddWithValue("@cy",County);
            cmd.Parameters.AddWithValue("@dob",DoB);
            cmd.Parameters.AddWithValue("@ge",Gender);
            cmd.Parameters.AddWithValue("@stuNum",StuNum);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }






    }
}
