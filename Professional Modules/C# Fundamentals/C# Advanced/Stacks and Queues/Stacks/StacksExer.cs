using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
   public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            Stack<string> number = new Stack<string>();
            foreach (var item in input)
            {
                number.Push(item);
            }
            int n = number.Count;
            for (int i = 0; i < n; i++)
            {
               string num =  number.Pop();
                Console.Write($"{num} ");
            }
           

        }
    }
}
