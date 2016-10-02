using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

       
        for (int i = 111111; i <= 999999; i++)
        {
           
            int ostatak = i;
            int proizvedenie = 1;
            for (int p = 0; p < 6; p++)
            {
                
                int number = ostatak % 10;
                ostatak = ostatak / 10;
                
                proizvedenie *= number;
                
            }
            if (proizvedenie == n)
            {
                Console.Write("{0} ", i);
            }

        }
        
    }
}

