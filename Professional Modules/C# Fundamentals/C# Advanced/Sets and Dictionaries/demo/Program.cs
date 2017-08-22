using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Program
    {
        static void Main()
        {
            Stack<int> stack = new Stack<int>();
            string[] input = Console.ReadLine().Split();
            foreach (var item in input)
            {
                int rev = int.Parse(item);
                stack.Push(rev);
            }
            //int rev = int.Parse(input[i]);
            //stack.Push(rev);

            foreach (var item in stack)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
