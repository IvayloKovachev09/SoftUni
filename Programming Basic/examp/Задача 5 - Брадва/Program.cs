using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}*{1}*{2}",new string('-',n*3),new string('-',i),new string('-',((n*2)-2)-i));
        }
        for (int p = 0; p < n/2; p++)
        {
            Console.WriteLine("{0}*{1}*{1}",new string('*',n*3),new string('-',n-1));
        }
        for (int l = 1; l <= n/2-1; l++)
        {
            Console.WriteLine("{0}*{1}*{2}",new string('-',(n*3)-l+1),new string('-',(n-3)+2*l),new string('-',(n-1)-l+1));
        }
        Console.WriteLine("{0}*{1}*{2}",new string('-',(n*3)-(n/2-1)),new string('*',(n*3-2)-(((n * 3) - (n / 2 - 1)),new string('-',(n+1)/2));
        
    }
}

