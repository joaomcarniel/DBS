using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class Student : Person
    {
        public override int Age { get; set; }

        public Student (string name, int dob, int age)
                : base(name, dob)
        {
            Age = age;
        }

        public override int CallAge()
        {
            return Age;
        }
    }
}
