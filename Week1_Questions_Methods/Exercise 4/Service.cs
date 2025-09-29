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
                if(m+i != 0 && m + i != 1 && (m+i) % 2 != 0)
                {
                    listPrimeNum.Add(m + i);
                }
            }

            return listPrimeNum;
        }

        private bool IsPrime(int num)
        {
            if (num == 0 || num == 1) return false;
            for(int i = 2; i < num; i++)
            {
                num % i == 0
            }
        }
    }
}
