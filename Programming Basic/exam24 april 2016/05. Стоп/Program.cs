using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}",new string('.',n+1),new string('_',n*2+1));
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}//{1}\\\\{0}", new string('.',n-i), new string('_', (n * 2 - 1)+i*2));
        }
        Console.WriteLine("//{0}STOP!{0}\\\\",new string('_',(n*2)-3));
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}\\\\{1}//{0}",new string('.',i), new string('_', (n * 4 - 1) - i * 2));
        }

    }
}

