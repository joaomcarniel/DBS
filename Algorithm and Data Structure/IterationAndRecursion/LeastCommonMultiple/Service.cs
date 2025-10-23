using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeastCommonMultiple
{
    internal class Service
    {

        public long LCMByIteration(int numA, int numB)
        {
            return ((long)numA * (long)numB) / GCD(numA, numB);
        }
        public int GCD(int numA, int numB)
        {
            while(numB != 0)
            {
                int temp = numB;
                numB = numA % numB;
                numA = temp;
            }
            return numA;
        }

        public int LCMByRecursion(int smaller, int larger, int lcm)
        {
            if (lcm % smaller == 0 && lcm % larger == 0) return lcm;

            return LCMByRecursion(smaller, larger, lcm + 1);
        }
    }
}
