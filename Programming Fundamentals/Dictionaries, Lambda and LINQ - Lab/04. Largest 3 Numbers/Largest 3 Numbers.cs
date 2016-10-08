using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Largest_3_Numbers
{
    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            
            var a =nums.OrderByDescending(x => x).Take(3);
            Console.WriteLine(string.Join(" ",a));

        }
    }
}
