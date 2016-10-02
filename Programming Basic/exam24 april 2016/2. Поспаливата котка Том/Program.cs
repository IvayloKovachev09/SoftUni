using System;

class Program
{
    static void Main()
    {
        int holliday = int.Parse(Console.ReadLine());
        int rabotniDni = 365 - holliday;
        int vremeZaIgra = rabotniDni * 63 + holliday * 127;
        int minutiZaIgra = 30000 - vremeZaIgra;
        if (minutiZaIgra>0)
        {
            int chas = minutiZaIgra / 60;
            int minuti = minutiZaIgra- chas * 60;
            Console.WriteLine("Tom sleeps well");
            Console.WriteLine("{0} hours and {1} minutes less for play", chas,minuti);
        }
        else
        {
            int chas =( minutiZaIgra / 60);
            int minuti =(chas * 60 -minutiZaIgra);
            Console.WriteLine("Tom will run away");
            Console.WriteLine("{0} hours and {1} minutes more for play",Math.Abs( chas), minuti);

        }
    }
}

