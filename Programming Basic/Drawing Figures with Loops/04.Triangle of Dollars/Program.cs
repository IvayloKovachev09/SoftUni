using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < n; i++)
        {
            Console.Write("$");
            for (int r = 0; r < i; r++)
            {
                Console.Write(" $");
            }
            Console.WriteLine();
        }
    }
}

