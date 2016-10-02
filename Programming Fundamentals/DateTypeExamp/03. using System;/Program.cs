using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        decimal sum = 0;
        for (int i = 0; i < number; i++)
        {
            decimal num = decimal.Parse(Console.ReadLine());
            sum += num;
        }
        Console.WriteLine(sum);
    }
}

