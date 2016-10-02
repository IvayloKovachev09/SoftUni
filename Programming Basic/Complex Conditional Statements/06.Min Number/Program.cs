using System;

    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int chislo = int.MaxValue;
            for (int i = 0; i < num; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < chislo)
                {
                    chislo = number;
                }
            }
            Console.WriteLine(chislo);
        }
    }

