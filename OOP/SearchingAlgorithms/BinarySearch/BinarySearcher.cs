namespace BinarySearch
{
    public class BinarySearcher
    {
        public int GetKeyElement(int[] numList, int keyElement)
        {
            int midIndex = numList.Length / 2;
            int low = 0;
            int high = numList.Length - 1;

            while (true)
            {
                if (numList[midIndex] == keyElement) return numList[midIndex];

                if (numList[midIndex] > keyElement)
                {
                    high = midIndex;
                }
                else
                {
                    low = midIndex;
                }
                midIndex = ((high - low) / 2) + low;
            }
        }
    }
}
