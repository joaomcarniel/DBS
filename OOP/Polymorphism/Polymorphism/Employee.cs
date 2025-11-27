namespace Polymorphism
{
    public class Employee
    {
        public string name;
        protected decimal basepay;
        public Employee(string name, decimal basepay)
        {
            this.name = name;
            this.basepay = basepay;
        }

        public virtual decimal CalculatePay() { return basepay; }
    }
}
