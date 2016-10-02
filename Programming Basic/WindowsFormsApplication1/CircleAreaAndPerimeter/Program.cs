using System;



    class Program
    {
        static void Main()
        {
            Console.Write("Enter circle radius. r= ");
            double r = double.Parse(Console.ReadLine());
            double pi = Math.PI;
            Console.WriteLine("Area = {0}", (pi * r * r));
            Console.WriteLine("Perimeter = {0}", (2 * pi * r));
            
        }
    }

