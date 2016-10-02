using System;

    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int sumLeft = 0;
            int sumRight = 0;
            for (int i = 0; i < num*2; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i<num)
                {
                    sumLeft += number;
                }
                else
                {
                    sumRight += number;
                }
                
            }
            if (sumRight == sumLeft)
            {
                Console.WriteLine("Yes, " + ("sum=" + sumLeft));
            }
            else
            {
                Console.WriteLine("No, " + ("diff =" + Math.Abs(sumLeft - sumRight)));
            }
        }
    }

