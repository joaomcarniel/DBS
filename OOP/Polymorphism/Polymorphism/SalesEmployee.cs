namespace Polymorphism
{
    public class SalesEmployee : Employee
    {
        private decimal bonus;

        public SalesEmployee(string name, decimal basepay, decimal bonus)
                : base (name, basepay) 
        {
            this.bonus = bonus;
        }

        public override decimal CalculatePay()
        {
            return basepay + bonus;
        }
    }
}
