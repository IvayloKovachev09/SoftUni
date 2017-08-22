using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] operationNumbers = Console.ReadLine().Split();
        string[] numbersOfStack = Console.ReadLine().Split();
        int countOfStack = int.Parse(operationNumbers[0]);
        int popOfStack = int.Parse(operationNumbers[1]);
        string searchNumber = operationNumbers[2];

        
        Stack<string> rundomNumber = new Stack<string>();
        for (int i = 0; i < countOfStack; i++)
        {
            rundomNumber.Push(numbersOfStack[i]);
        }
        
        for (int i = 0; i < popOfStack; i++)
        {
            rundomNumber.Pop();
        }
        if (rundomNumber.Contains(searchNumber))
        {
            Console.WriteLine("true");
        }
        else if (countOfStack == popOfStack)
        {
            Console.WriteLine("0");
        }
        else
        {
            int[] num = rundomNumber.Select(int.Parse).ToArray();
            Console.WriteLine(num.Min());
        }



    }
}

