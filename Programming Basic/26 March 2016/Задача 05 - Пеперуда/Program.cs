using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n-2; i++)
        {
            if (i%2==0)
            {
                Console.WriteLine("{0}\\ /{0}",new string('*',n-2));
            }
            else
            {
                Console.WriteLine("{0}\\ /{0}", new string('-', n - 2));
            }
        }
        Console.WriteLine("{0}@",new string(' ',n-1));
        for (int p = 0; p < n-2; p++)
        {
            if (p % 2 == 0)
            {
                Console.WriteLine("{0}/ \\{0}", new string('*', n - 2));
            }
            else
            {
                Console.WriteLine("{0}/ \\{0}", new string('-', n - 2));
            }
        }
    }
}

