using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int nextNumber = 0;
        for (int i = 0; i < n; i++)
        {
            nextNumber += 1;
           
            for (int p = 0; p < n; p++)
            {
                if (i%2==0 &&)
                {
                    Console.Write(nextNumber);
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.Write(nextNumber);
                    break;
                }
            }
        }
    }
}

