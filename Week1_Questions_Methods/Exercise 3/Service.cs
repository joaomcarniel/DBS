namespace Exercise_3
{
    public class Service
    {
        public int SumAllNumbers(int m, int n)
        {
            int sum = 0;
            for(int i = m; i <= n; i++)
            {
                sum += i;
            }

            return sum;
        }

        public int SumEvenNumbers(int m, int n)
        {
            int sum = 0;
            for(int i = m; i <= n; i++)
            {
                if(i % 2 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        public int SumOddNumbers(int m, int n)
        {
            int sum = 0;
            for(int i = m; i <= n; i++)
            {
                if(i % 2 != 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
