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

            Stack<int> stackNumbers = new Stack<int>();
            Stack<int> maxNumber = new Stack<int>();
            maxNumber.Push(0);
            maxNumber.Push(0);
            maxNumber.Push(0);
            int n = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                int firstElementFromCommand = int.Parse(command[0]);

                if (firstElementFromCommand == 1)
                {
                    int secondElementFromCommand = int.Parse(command[1]);
                    stackNumbers.Push(secondElementFromCommand);
                    if (secondElementFromCommand > maxNumber.Peek())
                    {
                       
                        maxNumber.Push(secondElementFromCommand);
                    }
                }
                else if (firstElementFromCommand == 2)
                {
                    int remove =stackNumbers.Pop();
                    if (remove==maxNumber.Peek())
                    {
                        maxNumber.Pop();
                    }
                   
                }
                else
                {
                    Console.WriteLine(maxNumber.Peek());
                }
            }

        }
    }
}
