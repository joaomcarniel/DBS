namespace ProductOfNumbers
{
    internal class Service
    {
        public int ProductByIteration(int[] array)
        {
            int product = 1;

            for(int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }

            return product;
        }

        public int ProductByRecursion(int[] array, int index = 0)
        {
            if(index == array.Length - 1)
            {
                return array[index];
            }

            return array[index] * ProductByRecursion(array, index + 1);
        }
    }
}
