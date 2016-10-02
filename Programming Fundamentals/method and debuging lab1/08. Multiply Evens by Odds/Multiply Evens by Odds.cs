using System;

public class Program
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(GetMultipleOfEvensAndOdds(Math.Abs(number)));
    
    }
    public static int GetMultipleOfEvensAndOdds(int number)
    {
        int sumEvens = GetSumEvens(number);
        int sumOdd = GetSumOdd(number);
        return sumOdd * sumEvens;
    }
    public static int GetSumEvens(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            int lastDigit = number % 10;
            if (lastDigit % 2 == 0)
            {
                sum += lastDigit;
            }
            number /= 10;
        }
        return sum;
    }
    public static int GetSumOdd(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            int lastDigit = number % 10;
            if (lastDigit % 2 != 0)
            {
                sum += lastDigit;
            }
            number /= 10;
        }
            return sum;
        
    }
    
}

