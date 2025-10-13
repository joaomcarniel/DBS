using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnStu_Click(object sender, EventArgs e)
        {
            var firstName = firstNameStu.Text;
            var surname = surnameStud.Text;
            var county = countyStud.SelectedItem.ToString();
            var dob = dobStudent.Text;
            var gender = "male";
            if (femaleStud.Checked)
            {
                gender = "female";
            }
            var stuNum = int.Parse(stuNumberStu.Text);
            var student = new Student(firstName, surname, county, dob, gender, stuNum);
            student.AddStudent();
            firstNameStu.Text = "";
            surnameStud.Text = "";
            stuNumberStu.Text = "";
        }

        private void btnLec_Click(object sender, EventArgs e)
        {
            var firstName = firstNameLec.Text;
            var surname = surnameLec.Text;
            var county = countyLec.SelectedItem.ToString();
            var dob = dobLec.Text;
            var gender = "male";
            if (femaleLec.Checked)
            {
                gender = "female";
            }
            var modules = modulesLec.Text;
            decimal pay = decimal.Parse(payLec.Text);

            Lecturer l = new Lecturer(firstName, surname, county, dob, gender, modules, pay);
            l.AddLecturer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            countyStud.DataSource = Enum.GetValues(typeof(Counties));
            countyLec.DataSource = Enum.GetValues(typeof(Counties));
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
