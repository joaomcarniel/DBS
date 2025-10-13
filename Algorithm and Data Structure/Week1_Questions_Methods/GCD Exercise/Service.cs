namespace GCD_Exercise
{
    public class Service
    {

        public int GetGCD(int numA, int numB)
        {
            int GreatestPossible = numA > numB ? numA / 2 : numB / 2;
            int response = 1;

            for(int i = 1; i < GreatestPossible; i++)
            {
                if(numA % i == 0 && numB % i == 0)
                {
                    response = i;
                }
            }

            return response;
        }
    }
}
