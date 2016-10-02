using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Смяна на долари = ");
            var usd = double.Parse(Console.ReadLine());
            var bgn = Math.Round((1.79549 * usd),2);
            Console.WriteLine(bgn+" BGN");

           
        }
    }
