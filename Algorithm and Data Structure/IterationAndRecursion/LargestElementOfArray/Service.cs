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

        public int LargestElementOfArrayByRecursion(int[] arrayNum, int lastIndex)
        {
            if(arrayNum.Length == 1 || lastIndex == 0)
            {
                return arrayNum[0];
            }

            return Max(arrayNum[lastIndex], LargestElementOfArrayByRecursion(arrayNum, lastIndex - 1));
        }

        public int Max(int num1,int num2)
        {
            return num1 > num2 ? num1 : num2;
        }
    }
}
