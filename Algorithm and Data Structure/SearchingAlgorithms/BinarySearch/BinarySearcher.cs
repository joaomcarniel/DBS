namespace BinarySearch
{
    public class BinarySearcher
    {
        public int GetKeyElement(int[] numList, int keyElement)
        {
            int low = 0;
            int high = numList.Length - 1;

            while (low <= high)
            {
                int midIndex = low + (high - low) / 2;
                if (numList[midIndex] == keyElement) return midIndex;

                if (numList[midIndex] > keyElement)
                {
                    high = midIndex - 1;
                }
                else
                {
                    low = midIndex + 1;
                }
            }
            return -1;
        }
    }
}
