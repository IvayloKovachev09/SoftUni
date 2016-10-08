using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Sum__Min__Max__Average
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] areyOfNums = new int[n];
            for (int i = 0; i < n; i++)
            {
                areyOfNums[i] = int.Parse(Console.ReadLine());
            
            }
            Console.WriteLine("Sum = {0}",areyOfNums.Sum());
            Console.WriteLine("Min = {0}",areyOfNums.Min());
            Console.WriteLine("Max = {0}",areyOfNums.Max());
            Console.WriteLine("Average = {0}", areyOfNums.Average());
        }
    }
}
