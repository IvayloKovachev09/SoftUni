using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact =fact*i;
        }

        Console.WriteLine(fact);
    }
}

