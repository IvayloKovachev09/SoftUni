using System;

    class Program
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = 0; i < num; i++)
            {
                var chislo = int.Parse(Console.ReadLine());
                sum += chislo;
            }
            Console.WriteLine(sum);
        }
    }

