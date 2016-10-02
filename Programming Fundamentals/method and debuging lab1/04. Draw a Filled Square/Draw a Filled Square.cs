using System;

public class Program
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        PrintFirstLine(num);
        for (int i = 0; i < num-2; i++)
        {
            PrintMiddleLine(num);
        }
        PrintFirstLine(num);
    }
    public static void PrintFirstLine(int number)
    {
        Console.WriteLine("{0}",new string('-',number*2));
    }
    public static void PrintMiddleLine(int number)
    {
        Console.Write("-");
        for (int i = 0; i < number-1; i++)
        {
            Console.Write("\\/");
        }
        Console.WriteLine("-");
    }
}

