using System;



    class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double width = Math.Abs(x1 - x2);
            double height = Math.Abs(y1 - y2);
            Console.WriteLine("Area = {0}", (width * height));
            Console.WriteLine("Perimeter = {0}",(width+height)*2);
        }
    }

