using System;

class Program
{
    static void Main()
    {
        int obem = int.Parse(Console.ReadLine());
        int debitFirstPipe = int.Parse(Console.ReadLine());
        int debitSecondPipe = int.Parse(Console.ReadLine());
        double hour = double.Parse(Console.ReadLine());

        double obemFirstPipe = debitFirstPipe * hour;
        double obemSecondPipe = debitSecondPipe * hour;
        double sumObem = obemFirstPipe + obemSecondPipe;

        if (sumObem<=obem)
        {
            double procentToPool = (sumObem / obem) * 100;
            double procentFirstPipe = (obemFirstPipe / sumObem) * 100;
            double procentSecondPipe = (obemSecondPipe / sumObem) * 100;
            Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", Math.Floor(procentToPool), Math.Floor( procentFirstPipe), Math.Floor(procentSecondPipe));
        }
        else
        {
            double litreMore = sumObem - obem;
            Console.WriteLine("For {0} hours the pool overflows with {1} liters.",hour,litreMore);
        }

    }
}

