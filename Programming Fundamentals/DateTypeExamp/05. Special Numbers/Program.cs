using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
       
        for (int i = 1; i <= n; i++)
        {
            int sumOfDigits = 0;
            int digits = i;
            if (i<=9)
            {
                sumOfDigits = i;
            }
            else
            {
                int firstNumber = i % 10;
                int secondNumber = i / 10;
                sumOfDigits = firstNumber + secondNumber;
            }
            bool special = (sumOfDigits == 5) || (sumOfDigits==7) || (sumOfDigits == 11); // TODO: finish this
            Console.WriteLine("{0} -> {1}", i, special);
        }
    }
}

