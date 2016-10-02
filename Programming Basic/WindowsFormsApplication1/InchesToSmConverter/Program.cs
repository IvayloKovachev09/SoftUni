using System;




    class Program
    {
        static void Main()
        {
            var num = decimal.Parse(Console.ReadLine());
            var inch = 2.54M;

            var centimetres = num * inch;
            Console.WriteLine(centimetres);
        }
    }

