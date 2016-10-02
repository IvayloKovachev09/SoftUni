using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        while (b!=0)
        {
            var oldB = b;
            b = a % b;
            a = oldB;

        }
        Console.WriteLine(b);

    }
}

