using System;

public class Program
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        PrintSign(num);
    }

    static void PrintSign(int number)
    {
        if (number > 0)
            Console.WriteLine("The number {0} is positive", number);
        else if (number < 0)
            Console.WriteLine("The number {0} is negative.", number);
        else
            Console.WriteLine("The number {0} is zero.", number);
    }


}

