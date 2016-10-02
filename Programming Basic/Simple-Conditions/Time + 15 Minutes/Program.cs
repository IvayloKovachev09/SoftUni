using System;

    class Program
    {
        static void Main()
        {
            var hour = int.Parse(Console.ReadLine());
            var minuti = int.Parse(Console.ReadLine());
            var minSum = minuti + 15;
            if (hour <= 23 && minuti <= 44)
            {
                Console.WriteLine("{0}:{1:00}",hour,minSum);
            }
            else if (hour < 23 && minuti >=45 && minuti <= 59)
            {
                hour += 1;
                minuti = minSum - 60;
                Console.WriteLine("{0}:{1:00}",hour,minuti);
            }
            else if (hour == 23 && minuti >=45 && minuti <= 59)
            {
                hour = 0;
                minuti = minSum - 60;
                Console.WriteLine("{0}:{1:00}",hour,minuti);
            }
        }
    }

