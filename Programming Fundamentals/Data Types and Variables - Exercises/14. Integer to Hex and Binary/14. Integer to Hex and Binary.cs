using System;

public class Program
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        var hexadecimal = Convert.ToString(number, 16).ToUpper();
        var binary = Convert.ToString(number, 2);
        Console.WriteLine(hexadecimal);
        Console.WriteLine(binary);
    }
}

