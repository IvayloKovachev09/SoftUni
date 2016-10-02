using System;

public class Program
{
    public static void Main()
    {
        string name = Console.ReadLine();
        Console.WriteLine(HelloName(name));
    }
    public static string HelloName(string name)
    {
        return "Hello,"+" "+name+"!";
    }
}

