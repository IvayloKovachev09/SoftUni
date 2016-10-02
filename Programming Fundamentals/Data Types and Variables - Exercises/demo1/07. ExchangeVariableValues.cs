using System;

public class Program
{
    public static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Before:");
        Console.WriteLine("a = {0}",a);
        Console.WriteLine("b = {0}",b);
        int c = b;
        Console.WriteLine("After:");
        Console.WriteLine("a = {0}", c);
        Console.WriteLine("b = {0}", a);

    }
}

