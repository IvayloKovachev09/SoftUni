using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var number = 1;
        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine(number);
            number = number * 2;
        }
    }
}
