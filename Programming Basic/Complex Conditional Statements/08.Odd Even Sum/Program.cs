using System;

class Program
{
    static void Main()
        {
        int numberOfNum = int.Parse(Console.ReadLine());
        var oddSum = 0;
        var evenSum = 0;

        for (int i = 0; i < numberOfNum; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                oddSum += num;
            }
            else
            {
                evenSum += num;
            }
        }
        if (oddSum == evenSum)
        {
            Console.WriteLine("Yes Sum = "+oddSum);
        }
        else
        {
            var result = Math.Abs(evenSum - oddSum);
            Console.WriteLine("No Diff = "+result);
        }
        }
}

