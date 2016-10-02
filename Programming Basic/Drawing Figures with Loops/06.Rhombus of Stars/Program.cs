using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (var row = 1; row <= n; row++)
        {
            for (var col = 1; col <= n - row; col++)
            {
                Console.Write(" ");
            }
            Console.Write("*");
            for (var col = 1; col < row; col++)
            {
                Console.Write(" *");
            }
            Console.WriteLine();
        }
        for (var row =1; row < n; row++)
        {
            for (var col = 1; col <= row; col++)
            {
                Console.Write(" ");
            }
            Console.Write("*");
            for (var col = n; col > row+1; col--)
            {
                Console.Write(" *");
            }
            Console.WriteLine();
        }


    }
}

