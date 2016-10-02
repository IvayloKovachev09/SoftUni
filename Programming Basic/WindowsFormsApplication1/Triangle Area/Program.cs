using System;

    class Program
    {
        static void Main()
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal h = decimal.Parse(Console.ReadLine());
            var area = Math.Round(((a * h) / 2), 2);
            Console.WriteLine("Triangle Area = {0}",area);

        }
    }

