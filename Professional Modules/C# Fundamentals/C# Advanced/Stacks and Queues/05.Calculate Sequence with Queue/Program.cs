using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Calculate_Sequence_with_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            Queue<double> numbersForProblem = new Queue<double>();
            Queue<double> numbersForAnswer = new Queue<double>();
            numbersForAnswer.Enqueue(number);
            numbersForProblem.Enqueue(number);
            for (int i = 0; i < 17; i++)
            {
                for (int p = 0; p < 3; p++)
                {
                    double firstOutNumberFromStack = numbersForProblem.Dequeue();
                    numbersForAnswer.Enqueue(firstOutNumberFromStack + 1);
                    numbersForProblem.Enqueue(firstOutNumberFromStack + 1);
                    numbersForAnswer.Enqueue(2 * firstOutNumberFromStack + 1);
                    numbersForProblem.Enqueue(2 * firstOutNumberFromStack + 1);
                    numbersForAnswer.Enqueue(firstOutNumberFromStack + 2);
                    numbersForProblem.Enqueue(firstOutNumberFromStack + 2);

                }
            }
                
            for (int i = 0; i < 50; i++)
            {
                Console.Write($"{numbersForAnswer.Dequeue()} ");
            }
           
        }
    }
}
