using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3LpfApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const long targetNumber = 600851475143;
            var primeFactors = new List<long>();

            for (long i = 1; i <= targetNumber; i++)
            {
                Console.WriteLine(i);
                if (PrimeFactor(targetNumber, i))
                {
                    primeFactors.Add(i);
                }
            }

            var biggestPrimeFactor = primeFactors.Max();

            Console.WriteLine(biggestPrimeFactor);

        }

        public static bool PrimeFactor(long number, long i)
        {
            return number % i == 0;
        }
    }
}
