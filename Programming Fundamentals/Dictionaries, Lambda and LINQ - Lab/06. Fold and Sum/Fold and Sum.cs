using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_Sum
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = numbers.Length / 4;
            var row1Left = numbers.Take(k).Reverse().ToArray();
            var row1Right = numbers.Reverse().Take(k).ToArray();
            var row1 = row1Left.Concat(row1Right).ToArray();
            var row2 = numbers.Skip(k).Take(2 * k).ToArray();
            var sum = row1.Select((x, index) => x + row2[index]);

            Console.WriteLine(string.Join(" ",sum));

        }
    }
}