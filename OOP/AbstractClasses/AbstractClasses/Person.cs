namespace AbstractClasses
{
    public abstract class Person
    {
        public string Name;
        public abstract int Age { get; set; }
        public int Dob { get; set; }

        public Person() { }
        public Person(string name, int dob)
        {
            this.Name = name;
            Dob = dob;
        }

        public abstract int CallAge();
        public int DOB() { return Dob; }


    }
}
