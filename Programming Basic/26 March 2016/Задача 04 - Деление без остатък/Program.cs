
using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double numberDiffTwo = 0;
        double numberDiffThree = 0;
        double numberDiffFour = 0;
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number%2==0)
            {
                numberDiffTwo += 1;
            }
            if (number % 3 == 0)
            {
                numberDiffThree += 1;
            }
            if (number % 4 == 0)
            {
                numberDiffFour += 1;
            }
        }
        Console.WriteLine("{0:f2}%",(numberDiffTwo/n)*100);
        Console.WriteLine("{0:f2}%", (numberDiffThree / n) * 100);
        Console.WriteLine("{0:f2}%", (numberDiffFour / n) * 100);
    }
}

