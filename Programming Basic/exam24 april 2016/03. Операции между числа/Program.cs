using System;

class Program
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        var operation = Console.ReadLine();

        if (operation=="+")
        {
            int sum = firstNumber + secondNumber;
            if (sum%2==0)
            {
                Console.WriteLine("{0} + {1} = {2} - even",firstNumber,secondNumber,sum);
            }
            else
            {
                Console.WriteLine("{0} + {1} = {2} - odd", firstNumber, secondNumber, sum);
            }
        }
        else if (operation=="-")
        {
            int different = firstNumber - secondNumber;
            if (different % 2 == 0)
            {
                Console.WriteLine("{0} - {1} = {2} - even", firstNumber, secondNumber, different);
            }
            else
            {
                Console.WriteLine("{0} - {1} = {2} - odd", firstNumber, secondNumber, different);
            }
        }
        else if (operation=="*")
        {
            int multiplication = firstNumber * secondNumber;
            if (multiplication % 2 == 0)
            {
                Console.WriteLine("{0} * {1} = {2} - even", firstNumber, secondNumber, multiplication);
            }
            else
            {
                Console.WriteLine("{0} * {1} = {2} - odd", firstNumber, secondNumber, multiplication);
            }
        }
        else if (operation=="/")
        {
            if (secondNumber==0)
            {
                Console.WriteLine("Cannot divide {0} by zero",firstNumber);
            }
            else
            {
                double firstNumber1 = (double)firstNumber;
                double secondNumber2 = (double)secondNumber;
                double partition = firstNumber1 / secondNumber2;
                Console.WriteLine("{0} / {1} = {2:f2}", firstNumber1, secondNumber2, partition);
            }
            
        }
        else if (operation == "%")
        {
            if (secondNumber == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", firstNumber);
            }
            else
            {
                double ostatak = firstNumber % secondNumber;
                Console.WriteLine("{0} % {1} = {2}", firstNumber, secondNumber, ostatak);
            }

        }
    }
}

