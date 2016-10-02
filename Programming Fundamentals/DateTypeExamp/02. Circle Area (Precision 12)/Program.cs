using System;

class Program
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:f12}",(decimal)(Math.PI*r*r));

    }
}

