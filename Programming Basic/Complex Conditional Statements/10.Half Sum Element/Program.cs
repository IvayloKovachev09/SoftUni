using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSE
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var max = 0;
            var sum = 0;
            for (int i = 0; i < number; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (max < num) max = num;
                sum += num;
            }
            sum = sum - max;
            if (max == sum)
            {
                Console.Write("Yes sum ");
                Console.WriteLine(sum);
            }
            else
            {
                Console.Write("No diff ");
                Console.WriteLine(Math.Abs(max - sum));
            }


        }
    }
}