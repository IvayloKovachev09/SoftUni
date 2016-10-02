using System;

class Program
{
    static void Main(string[] args)
    {
        int rabotniDni = int.Parse(Console.ReadLine());
        double pariDen = double.Parse(Console.ReadLine());
        double kursDolar = double.Parse(Console.ReadLine());

        double mesechnaZaaplata = rabotniDni * pariDen;
        double godishenDohod = mesechnaZaaplata * 12 + mesechnaZaaplata * 2.5;
        double danak = godishenDohod * 0.25;
        double chistGodishenDohod = (godishenDohod - danak) * kursDolar;
        double srednaPechalbaDen = chistGodishenDohod / 365;
        Console.WriteLine("{0:f2}",srednaPechalbaDen);
    }
}

