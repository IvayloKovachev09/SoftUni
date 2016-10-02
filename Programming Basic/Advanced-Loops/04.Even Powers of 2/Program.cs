using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int number = 1;
        for (int i = 0; i <= n/2; i++)
        {
            Console.WriteLine(number);
            number *= 4;
        }
    }
}

