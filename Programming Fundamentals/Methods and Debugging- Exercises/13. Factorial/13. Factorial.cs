using System;
using System.Numerics;

public class Program
{
    public static void Main()
    {
        long number = int.Parse(Console.ReadLine());
        BigInteger temno = 1;

        for (long i = 1; i <= number; i++)
        {
            temno = temno * i;
        }

        Console.WriteLine(temno);
    }
}

