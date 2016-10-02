using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
            {
            for (int p = 0; p < n; p++)
            {
                for (int r = 0; r < n; r++)
                {
                    char firstLater = (char)('a' + i);
                    char secondLater = (char)('a' + p);
                    char thirdLater = (char)('a' + r);
                    Console.WriteLine("{0}{1}{2}", firstLater, secondLater, thirdLater);
                }
            }

        }
        
    }
}

