using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Prime_Checker
{
    class Program
    {
        static void Main()
        {
            BigInteger inputNumber = BigInteger.Parse(Console.ReadLine());

            
            bool prime = IsPrime(inputNumber);

            
            Console.WriteLine(prime);
        }

        public static bool IsPrime(BigInteger candidate)
        {
            
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            for (BigInteger i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }
    }
}

