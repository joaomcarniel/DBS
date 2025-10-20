namespace CountDigitsOfNumber
{
    internal class Service
    {
        public int CountDigitsByIteration(int num)
        {
            if (num == 0 || num < 10)
            {
                return 1;
            }
            var response = 0;

            while (num != 0)
            {
                response++;
                num = num / 10;
            }

            return response;
        }

        public int CountDigitsByRecursion(int num)
        {
            if(num == 0 || num < 10)
            {
                return 1;
            }
            num = num / 10;
            return 1 + CountDigitsByRecursion(num);
        }
    }
}
