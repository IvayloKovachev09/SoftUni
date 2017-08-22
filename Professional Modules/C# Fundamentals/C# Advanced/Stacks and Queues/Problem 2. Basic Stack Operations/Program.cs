using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Basic_Stack_Operations
{
    class Program
    {
        private static object length;

        static void Main()
        {

            string[] counts = Console.ReadLine().Split();
            string[] numbersOfStack = Console.ReadLine().Split();
            Stack<int> numbers = new Stack<int>();

            int countOfStack = int.Parse(counts[0]);
            int popFromStack = int.Parse(counts[1]);
            int searchNumberInStack = int.Parse(counts[2]);

            for (int i = 0; i < countOfStack-popFromStack; i++)
            {
                numbers.Push(int.Parse(numbersOfStack[i]));
            }
            bool search = false;
            int maxValue = int.MaxValue;
            foreach (var item in numbers)
            {
                if (item==searchNumberInStack)
                {
                    Console.WriteLine("true");
                    search = true;
                }
                else if (item < maxValue )
                {
                    maxValue = item;
                }
               
            }
            if (search == false && numbers.Count > 0)
            {
                Console.WriteLine(maxValue);
            }
            else if(numbers.Count == 0)
            {
                Console.WriteLine(0);
            }
            
            

        }
    }
}
