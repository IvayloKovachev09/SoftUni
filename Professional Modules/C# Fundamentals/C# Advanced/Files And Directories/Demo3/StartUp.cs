using System;
using System.IO;

public class Startup
{
    public static void Main()
    {
        File.Copy("number.txt","another.txt");
        var numbers = File.ReadAllText("../../number.txt");
        Console.WriteLine(numbers);
    }
}

