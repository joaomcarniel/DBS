namespace Exercise1
{
    internal class Service
    {
        public int SumOfRangeByIteration(int n, int m)
        {
            int response = 0;
            for(int i = n; i <= m; i++)
            {
                response += i;
            }
            return response;
        }

        public int SumOfRangeByRecursion(int n, int m)
        {
            if(n == m)
                return n;
            return n + SumOfRangeByRecursion(n + 1, m);
        }
    }
}
