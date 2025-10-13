namespace RecursiveExercise
{
    public class Service
    {
        public int FactorialByIteration(int factorialNum)
        {
            if (factorialNum == 0) return 1;
            if (factorialNum < 0) return 0;
            int result = factorialNum;
            for (int i = factorialNum; i > 1; i--)
            {
                result = result * (i - 1);
            }

            return result;
        }

        public int FactorialByRecursion(int num)
        {
            if (num == 0 || num == 1 )
            {
                return 1;
            };
            return num * FactorialByRecursion(num - 1);
        }

        public int FibonacciByIteration(int num)
        {
            if (num == 0 || num == 1)
            {
                return num;
            }
            int fib = 0, fib0 = 0, fib1 = 1;
            for (int i = 2; i <= num; i++)
            {
                
                fib = fib0 + fib1;
                fib0 = fib1;
                fib1 = fib;

            }
            return fib;
        }

        public int FibonacciByRecursion(int num) // 6
        {
            if (num == 0 || num == 1) return num;

            return FibonacciByRecursion(num - 1) + FibonacciByRecursion(num - 2);
        }
    }
}
