using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < n; i++)
        {
            if (i == 0 || i == n-1)
            {
                Console.WriteLine("{0}{1}{0}",new string('*',n*2),new string(' ',n));
            }
            else
            {
                if (n%2==0 && i == n-(n/2)-1)
                {
                    Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", '*', new string('/', (n * 2) - 2), new string('|', n));
                }
                else if (n%2!=0 && i ==(n/2))
                {
                    Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", '*', new string('/', (n * 2) - 2), new string('|', n));
                }
                else
                {
                    Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", '*', new string('/', (n * 2) - 2), new string(' ', n));
                }
            }
        }
    }
}

