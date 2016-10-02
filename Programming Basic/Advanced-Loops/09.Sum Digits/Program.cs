using System;

    class Program
    {
        static void Main()
        {
        int n = int.Parse(Console.ReadLine());
        int numb = 1;
        int sum = 0;
        do
        {
            numb = n % 10;
            sum = sum + numb;
        } while (n>0);
        Console.WriteLine(sum);
        }
    }

