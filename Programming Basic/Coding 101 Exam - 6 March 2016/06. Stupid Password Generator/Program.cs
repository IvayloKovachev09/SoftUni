using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int l = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int d = 1; d <= n; d++)
            {
                for (var e = 'a'; e <'a'+ l; e++)
                {
                    for (var f = 'a'; f < 'a'+l; f++)
                    {
                        for (int d3 = Math.Max(i, d) + 1; d3 <= n; d3++)
                        {
                            Console.Write("{0}{1}{2}{3}{4} ",i, d, e, f, d3);
                        }
                      
                    }
                }
            }
        }
    }
}

