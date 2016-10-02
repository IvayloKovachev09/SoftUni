using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', 3 * n));
        var tochka = new string('.', n - 1);
        for (int i = 0; i < n-1; i++)
        {
            var nT = (n-1) - i;
            var midl = (3 * n) + 2*i;
            Console.WriteLine("{0}*{1}*{0}", new string('.', (nT)), new string('.', midl));
        }
        Console.WriteLine("{0}",new string('*',5*n));
        for (int i = 1; i <= n*2; i++)
        {
            var nT = i;
            var midl = (5 * n) - ((2*i)+2);
            Console.WriteLine("{0}*{1}*{0}", new string('.', (nT)), new string('.', midl));
        }
        Console.WriteLine("{0}{1}{0}", new string('.', (2*n+1)), new string('*', n-2));
    }

}