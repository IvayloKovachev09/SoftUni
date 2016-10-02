using System;

public class Program
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        for (int i = 2; i <= number; i++)
        {
            bool isTrueFalse = true;
            for (int p = 2; p <= Math.Sqrt(i); p++)
            {
                if (i % p == 0)
                {
                    isTrueFalse = false;
                    break;
                }
            }
            Console.WriteLine($"{i} -> {isTrueFalse}");
        }

    }
}

