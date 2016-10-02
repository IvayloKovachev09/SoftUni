using System;

    class Program
    {
        static void Main()
        {
            double value = double.Parse(Console.ReadLine());
            string unitFrom = Console.ReadLine();
            string unitTo = Console.ReadLine();
            if (unitFrom == "km")
            {
                value = value/0.001;
            }
            else if (unitFrom == "ft")
            {
                value = value / 3.2808399;
            }
            else if (unitFrom == "yd")
            {
                value = value / 1.0936133;
            }
            if (unitFrom == "mm")
            {
                value = value / 1000;
            }
            else if (unitFrom == "cm")
            {
                value = value / 100;
            }
            else if (unitFrom == "mi")
            {
                value = value / 0.000621371192;
            }
            else if (unitFrom == "m")
            {
                value = value / 1.0;
            }
            else if (unitFrom == "in")
            {
                value = value / 39.3700787;
            }


            if (unitTo == "ft")
            {
                value = value * 3.2808399;
            }
            else if (unitTo == "yd")
            {
                value = value * 1.0936133;
            }
            else if (unitTo == "mm")
            {
                value = value * 1000;
            }
            else if (unitTo == "cm")
            {
                value = value * 100;
            }
            else if (unitTo == "mi")
            {
                value = value * 0.000621371192;
            }
            else if (unitTo == "in")
            {
                value = value * 39.3700787;
            }
            else if (unitTo == "km")
            {
                value = value * 0.001;
            }
            else if (unitTo == "m") 
            {
                value = value * 1.0;
            }
            Console.WriteLine(value+" "+unitTo);
        }
    }

