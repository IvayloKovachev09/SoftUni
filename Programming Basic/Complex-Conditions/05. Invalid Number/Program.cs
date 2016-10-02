using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            bool isInRange = ((n >= 100 && n <= 200) || n == 0);
            if (!isInRange)
            {
                Console.WriteLine("invalid");
            }
           
           
        }
    }

