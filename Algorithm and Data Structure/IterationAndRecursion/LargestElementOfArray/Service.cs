namespace LargestElementOfArray
{
    internal class Service
    {
        public int LargestElementOfArrayByIteration(int[] arrayNum)
        {
            var largest = 0;

            for (int i = 0; i < arrayNum.Length; i++)
            {
                if (arrayNum[i] > largest)
                {
                    largest = arrayNum[i];
                }
            }

            return largest;
        }
    }
}
