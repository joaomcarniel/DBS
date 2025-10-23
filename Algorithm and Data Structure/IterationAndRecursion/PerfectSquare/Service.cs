using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectSquare
{
    internal class Service
    {

        public bool IsPerfectSquareByIteration(int number)
        {
            for(int i = 0; (i * i) <= number; i++)
            {
                if (i * i == number) return true;
            }

            return false;
        }

        public bool IsPerfectSquareByRecursion(int num, int aux = 1)
        {
            if (aux * aux == num) return true;
            if (aux * aux > num) return false;

            return IsPerfectSquareByRecursion(num, aux + 1);

        }
    }
}
