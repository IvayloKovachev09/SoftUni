using System;

public class Program
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine(GetMax(a,b,c));
    }
    public static int GetMax(int a,int b,int c)
    {
        return Math.Max(a, Math.Max(b, c));

    }
}

