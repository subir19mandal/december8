using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemFn2App
{
    class Program
    {
        static void Main(string[] args)
        {
            double count, f1 = 0, f2 = 1, f3, sum = 0;
            Console.Write("Enter the Limit : ");
            count = double.Parse(Console.ReadLine());
            for (; ; )
            {
                f3 = f1 + f2;
                if (f3 >= count)
                    break;
                if ((f3 % 2) == 0)
                {
                    sum += f3;
                }

                f1 = f2;
                f2 = f3;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
