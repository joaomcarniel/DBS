namespace Exercise_2
{
    public class Service
    {
        public void Sum(double a, double b)
        {
            Console.WriteLine($"{a + b}");
        }

        public void Subtract(double a, double b)
        {
            Console.WriteLine($"{a - b}");
        }

        public void Multiply(double a, double b)
        {
            Console.WriteLine($"{a * b}");
        }

        public void Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            else
            {
                Console.WriteLine($"{a / b}");
            }
        }
    }
}
