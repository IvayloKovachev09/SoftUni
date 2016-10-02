using System;

    class Program
    {
        static void Main()
        {
            var project = Console.ReadLine().ToLower();
            int row = int.Parse(Console.ReadLine());
            int colom = int.Parse(Console.ReadLine());
            double result = -1.0;
           

            if (project == "premiere")
            {
                result = (row * colom) * 12;
            }
            else if (project == "normal")
            {
                result = (row * colom) * 7.50;
            }
            else if (project == "discount")
            {
                result = (row * colom) * 5;
            }
            Console.Write("{0:f2}", result);
            Console.WriteLine(" leva");
        }   

    }

