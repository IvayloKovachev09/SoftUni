using System;

 public class Program
{
    public static void Main()
    {
        string numberSixteen = Console.ReadLine();

        int numberDecimal = Convert.ToInt32(numberSixteen, 16);
        Console.WriteLine(numberDecimal);
    }
}

