using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool num = true;
    
        for (int i = 2; i < n; i++)
        {
            if (n%i==0)
            {
                num = false;
                break;
            }
            
        }
        if (num==false || n<2)
        {
            Console.WriteLine("Not Prime");
        }
        else
        {
            Console.WriteLine("Prime");
        }
    }
}

