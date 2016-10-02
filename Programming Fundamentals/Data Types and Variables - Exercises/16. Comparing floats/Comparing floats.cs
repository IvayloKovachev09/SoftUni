using System;

public class Program
{
    public static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        double different = Math.Abs(a-b);
        bool isTrueFalse = false;
        if (different< 0.000001f)
        {
            isTrueFalse = true;
        }
        Console.WriteLine(isTrueFalse);
    }
}

