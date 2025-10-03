namespace Exercise_4
{
    public class Service
    {
        public int[] ArrayOfNumbers(int m, int n)
        {
            int[] arrayNum = new int[n - m + 1];
            for(int i = 0; i < arrayNum.Length; i++)
            {
                arrayNum[i] = m + i;
            }

            return arrayNum;
        }

        public List<int> ArrayOfPrimeNumbers(int m, int n)
        {
            List<int> listPrimeNum = new List<int>();
            for (int i = 0; i < (n-m+1); i++)
            {
                if(IsPrime(m+i))
                {
                    listPrimeNum.Add(m + i);
                }
            }

            return listPrimeNum;
        }

        private bool IsPrime(int num)
        {
            if (num == 0 || num == 1) return false;
            if (num == 2) return true;
            for(int i = num - 1; i > 1; i--)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}
