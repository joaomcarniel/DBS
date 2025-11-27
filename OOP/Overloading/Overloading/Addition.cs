namespace Overloading
{
    public class Addition
    {
        public int num1;
        public int num2;
        public Addition(int a, int b)
        {
            num1 = a;
            num2 = b;
        }
        public int Add()
        {
            return num1 + num2;
        }

        public int Add(int a) 
        {
            return a + num1;
        }

    }
}
