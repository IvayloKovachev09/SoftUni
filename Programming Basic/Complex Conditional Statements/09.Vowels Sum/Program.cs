using System;
class Program
{
    static void Main()
    {
        string duma = Console.ReadLine();
        int wordNumberSum = 0;
        for (int i = 0; i < duma.Length; i++)
        {
            if (duma[i] == 'a')
            {
                wordNumberSum += 1;
            }
            else if (duma[i] == 'e')
            {
                wordNumberSum += 2;
            }
            else if (duma[i] == 'i')
            {
                wordNumberSum += 3;
            }
            else if (duma[i] == 'o')
            {
                wordNumberSum += 4;
            }
            else if (duma[i] == 'u')
            {
                wordNumberSum += 5;
            }
        }
        Console.WriteLine(wordNumberSum);
    }
}

