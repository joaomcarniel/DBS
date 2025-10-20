namespace SumOfDigitsOfANumber
{
    internal class Service
    {
        public int SumOfDigitsByIteration(int num)
        {
            var response = 0;
            while(num != 0)
            {
                int reminder = num % 10;
                response += reminder;
                num /= 10;
            }

            return response;
        }

        public int SumOfDigitsByRecursion(int num)
        {
            if (num == 0) return 0;

            return num % 10 + SumOfDigitsByRecursion(num / 10);
        }
    }
}
