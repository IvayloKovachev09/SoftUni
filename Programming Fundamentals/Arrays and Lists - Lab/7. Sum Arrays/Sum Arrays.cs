using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrFirst = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var arrSecond = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var n = Math.Max(arrFirst.Length, arrSecond.Length);
            var sum = new int[n];
            for (int i = 0; i< n; i++)
            {
                sum[i] = arrFirst[i % arrFirst.Length] + arrSecond[i % arrSecond.Length];
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}


