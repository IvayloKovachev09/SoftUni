using System;

public class Program
{
    public static void Main()
    {
        string numbers = Console.ReadLine();
        string[] arrOfNumbers = numbers.Split(' ');

        double[] values = new double[arrOfNumbers.Length];
        for (int i = 0; i < arrOfNumbers.Length; i++)
        {
            values[i] = double.Parse(arrOfNumbers[i]);
            
        }
        for (int i = 0; i < arrOfNumbers.Length; i++)
        {
            values[i] = (int)Math.Round(values[i],
            MidpointRounding.AwayFromZero);
        }
        for (int i = 0; i < values.Length; i++)
        {
            Console.WriteLine($"{arrOfNumbers[i]} => {values[i]}");
        }
    }
}

