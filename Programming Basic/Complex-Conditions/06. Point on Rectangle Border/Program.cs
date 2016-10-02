using System;

    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool isInTop = (y == y1) && (x >= x1 && x <= x2);
            bool isInBottom = (y == y2) && (x >= x1 && x <= x2);
            bool isInLeft = (x == x1) && (y >= y1 && y <= y2);
            bool isInRight = (x == x2) && (y >= y1 && y <= y2);
            if (isInTop || isInBottom || isInLeft || isInRight)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
        
    }

