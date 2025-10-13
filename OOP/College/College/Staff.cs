namespace College
{
    internal class Staff : Person
    {
        public decimal Pay {  get; set; }
        public Staff(string fn, string sn, string cy, string dob, string ge, decimal pay)
            :base(fn, sn, cy, dob, ge)
        {
            Pay = pay;
        }

    }
}
