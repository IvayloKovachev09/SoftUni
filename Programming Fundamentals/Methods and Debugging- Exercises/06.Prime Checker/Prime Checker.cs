using System;

public class Program
{
    public static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        Console.WriteLine(IsPrime(number));
    }
    public static bool IsPrime(long number)
    {
        if (number == 0) return false;
        if (number == 1) return false;
        if (number == 2) return true;

        var boundary = (long)Math.Floor(Math.Sqrt(number));

        for (long i = 2; i <= boundary; ++i)
        {
            if (number % i == 0) return false;
        }

        return true;
    }
}


