using System;

class Program
{
    static void Main()
    {
        int loze = int.Parse(Console.ReadLine());
        double grozde = double.Parse(Console.ReadLine());
        int nujnoVino = int.Parse(Console.ReadLine());
        int raotnici = int.Parse(Console.ReadLine());

        double sumGrozde = loze * grozde;
        double vino = (sumGrozde * 0.4)/2.5;
        if (vino>nujnoVino)
        {
            double ostavashtoVino = (vino - nujnoVino);
            Console.WriteLine("Good harvest this year! Total wine: {0} liters.",Math.Round(vino));
            Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling( ostavashtoVino), Math.Ceiling( ostavashtoVino /raotnici));
        }
        else
        {
            double nedostigVino = nujnoVino - vino;
            Console.WriteLine("It will be a tough winter! More {0} liters wine needed.",Math.Round( nedostigVino));
        }
    }
}

