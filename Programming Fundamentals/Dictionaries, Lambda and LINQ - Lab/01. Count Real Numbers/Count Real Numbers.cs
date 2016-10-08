using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Real_Numbers
{
    class Program
    {
        static void Main()
        {
            var nameString = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var counts = new SortedDictionary<double, int>();

            foreach (var named in nameString)
            {
                double numbers = named;
                if (counts.ContainsKey(numbers))
                    counts[numbers]++;
                else
                    counts[numbers] = 1;

            }
            foreach (var num in counts.Keys)
            {
                Console.WriteLine($"{num} -> {counts[num]}");
            }

        }
    }
}
