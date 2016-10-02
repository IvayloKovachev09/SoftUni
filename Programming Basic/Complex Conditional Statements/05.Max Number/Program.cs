using System;

    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            for (int i = 0; i < num; i++)
            {
                int chislo = int.Parse(Console.ReadLine());
                if (chislo > max)
                {
                    max = chislo;
                }
                
            }
            Console.WriteLine(max);
        }    
    }

