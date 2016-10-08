using System;
using System.Collections.Generic;
using System.Linq;

class CenterPoint
{
    static void Main()
    {
        string[] arrayNumbers = Console.ReadLine().Split();
        int[] array = new int[arrayNumbers.Length];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(arrayNumbers[i]);
        }
        bool isFound = false;
        for (int i = 0; i < array.Length - 1; i++)
        {
            int firstNumber = array[i];
            for (int j = i + 1; j < array.Length; j++)
            {
                int secondNumber = array[j];
                int sum = firstNumber + secondNumber;

                if (array.Contains(sum))
                {
                    Console.WriteLine($"{firstNumber} + {secondNumber} == {sum}");
                    isFound = true;
                }

            }
        }
        if (!isFound)
        {
            Console.WriteLine("No");
        }
    }
}

