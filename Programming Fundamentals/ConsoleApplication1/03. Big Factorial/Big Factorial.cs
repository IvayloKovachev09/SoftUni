using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _03.Big_Factorial
{
    class Program
    {
        public static object BigIntiger { get; private set; }

        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);

        }
    }
}
