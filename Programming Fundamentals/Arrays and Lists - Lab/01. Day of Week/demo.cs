using System;

public class Program
{
    public static void Main()
    {
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        int number = int.Parse(Console.ReadLine());

        if (number>=1 && number<=7)
        {
            Console.WriteLine(days[number-1]);
        }
        else
        {
            Console.WriteLine("Invalid day!");
        }
    }
}

