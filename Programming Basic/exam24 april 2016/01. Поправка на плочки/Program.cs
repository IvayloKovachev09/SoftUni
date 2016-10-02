using System;

class Program
{
    static void Main()
    {
        int ploshtadka = int.Parse(Console.ReadLine());
        double stranaPlochka1 = double.Parse(Console.ReadLine());
        double stranaplochka2 = double.Parse(Console.ReadLine());
        int stranaPejka1 = int.Parse(Console.ReadLine());
        int stranapeika2 = int.Parse(Console.ReadLine());

        int kvadratiPlosht = ploshtadka * ploshtadka;
        int kvadratiPejka = stranaPejka1 * stranapeika2;
        int ploshtZaPokrivane = kvadratiPlosht - kvadratiPejka;
        double ploshtEdnaOlochka = stranaPlochka1 * stranaplochka2;
        double poktivanePlochki = ploshtZaPokrivane / ploshtEdnaOlochka;
        double vreme = 0.2 * poktivanePlochki;
        Console.WriteLine(poktivanePlochki);
        Console.WriteLine(vreme);

    }
}

