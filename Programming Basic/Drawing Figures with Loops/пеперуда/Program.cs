using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n - 2; i++)
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
        for (int id = 0; id < n - 2; id++)
        {
            if (id % 2 == 0)
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

