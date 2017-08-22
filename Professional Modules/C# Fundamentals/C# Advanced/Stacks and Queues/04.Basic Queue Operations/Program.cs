using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Basic_Queue_Operations
{
    class Program
    {
        static void Main()
        {
            string[] command = Console.ReadLine().Split();
            string[] numbersToQueue = Console.ReadLine().Split();
            int numbersCountQueue = int.Parse(command[0]);
            int numbersDequeue = int.Parse(command[1]);
            int searchNumber = int.Parse(command[2]);
            int minNumber = int.MaxValue;
            bool isResult = false;
            
            Queue<int> queue = new Queue<int>();

            for (int i = numbersDequeue; i < numbersCountQueue; i++)
            {
                int num = int.Parse(numbersToQueue[i]);
                queue.Enqueue(num);
                if (num < minNumber)
                {
                    minNumber = num;
                }
            }
            while (queue.Count>0)
            {
               int search =  queue.Dequeue();
                if (searchNumber == search)
                {
                    isResult = true;
                }
                
            }
            if (isResult)
            {
                Console.WriteLine("true");
            }
            else if (minNumber==int.MaxValue)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(minNumber);
            }
           
            
                
            
        }
    }
}
