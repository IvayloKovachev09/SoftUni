using System;

class Program
{
    static void Main()
    {
        Console.Write("Еnter a number in the range [1...100]: ");
        int n = int.Parse(Console.ReadLine());
        while (1>n || n>100)
        {
            Console.WriteLine("Invalid number!");
            n = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The number is: {0}",n);
    }
}

