using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int three = n % 10;
        int two = (n / 10) % 10;
        int one = (n / 100) % 10;

        int chislo = n;
        for (int i = 0; i < one+two; i++)
        {
            for (int p = 0; p < one+three; p++)
            {
                chislo = chislo + 0;
                if (chislo%5==0)
                {
                    chislo -=one;
                }
                else if (chislo%3==0)
                {
                    chislo -=two;
                }
                else
                {
                    chislo +=three;
                }
                Console.Write("{0} ",chislo);
            }
            Console.WriteLine();
        }
       

    }
}

