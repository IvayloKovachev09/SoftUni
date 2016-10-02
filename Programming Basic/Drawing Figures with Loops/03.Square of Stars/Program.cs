using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write("*");
            for (int s = 0; s < n-1; s++)
            {
                Console.Write(" *");
            }
            Console.WriteLine();
        }
    }
}

