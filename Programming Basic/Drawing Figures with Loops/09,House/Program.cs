using System;
  class Program
    {
        static void Main()
        {
        int n = int.Parse(Console.ReadLine());
        for (int p = 0; p < (n+1)/2; p++)
        {
            if (n %2 == 0)
            {
                var star = new string('*', (p * 2) + 2);
                var tire = new string('-', (n - 2) / 2-p);
                Console.WriteLine("{0}{1}{0}",tire,star);
            }
            else
            {
                var star = new string('*', (p * 2) + 1);
                var tire = new string('-', (n - 1) /2 -p);
                Console.WriteLine("{0}{1}{0}", tire, star);
            }
        }
        for (int i = 0; i < n/2; i++)
        {
            Console.WriteLine("{0}{1}{0}",new string('|',1),new string('*',n-2));
        }
        }
    }

