using System;

class Program
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
       
        for (int i = 1; i <= count; i++)
        {
            int sum = 0;
            int digits = i;
            while (i > 0)
            {
                sum += i % 10;
                i = i / 10;
            }
            bool trueFalse = (sum == 5) || (sum == 7) || (sum == 11);
            Console.WriteLine($"{digits} -> {trueFalse}");
            i = digits;
        }
    }
}


