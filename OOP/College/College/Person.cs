namespace College
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string County { get; set; }
        public string DoB { get; set; }
        public string Gender { get; set; }

        public Person(string firstName, string lastName, string county, string doB, string gender)
        {
            FirstName = firstName;
            LastName = lastName;
            County = county;
            DoB = doB;
            Gender = gender;
        }
    }
}
