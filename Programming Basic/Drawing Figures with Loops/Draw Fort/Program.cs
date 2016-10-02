using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var chovka = new string('^', n / 2);
        var tire = new string('_',(n*2)-((n/2)*2+4));
        var not = new string(' ', n / 2+1);
        var tiredown = new string('_', n / 2);
        Console.WriteLine("/{0}\\{1}/{0}\\",chovka,tire);
        for (int i = 1; i <= n-2; i++)
        {
           
            if (i==n-2)
            {
                Console.WriteLine("|{0}{1}{0}|",not,tire);
            }
            else
            {
                Console.WriteLine("|{0}|", new string(' ', (n * 2) - 2));
            }
            
        }
       
        Console.WriteLine("\\{0}/{1}\\{0}/",tiredown,new string(' ', (n * 2) - ((n / 2) * 2 + 4)));
    }
}

