using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Enter radians = ");
            var rad = double.Parse(Console.ReadLine());
            var deg = Math.Round(((180 / Math.PI) * rad), 0);
            Console.WriteLine("Radians is = {0}",deg);

        }
    }
