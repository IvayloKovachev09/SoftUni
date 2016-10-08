using System;
using System.Numerics;

public class Program
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        BigInteger fuctorial = FactorialNumber(number);
        Console.WriteLine(ZeroNumbers(fuctorial));
        
    }
    public static BigInteger FactorialNumber(int number)
    {
        BigInteger result = 1;

        for (int i = 1; i <= number; i++)
        {
            result = result * i;
        }
        return result;
    }
    public static int ZeroNumbers(BigInteger fuctorial)
    {
        int zeroSumNumbers = 0;
        BigInteger result = fuctorial;
        while (result % 10 == 0)
        {
            zeroSumNumbers += 1;
            result /= 10;
        }
        return zeroSumNumbers;

    }

}

