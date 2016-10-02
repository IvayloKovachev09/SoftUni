using System;

class Program
{
    static void Main()
    {
        int bitkoin = int.Parse(Console.ReadLine());
        double iuana = double.Parse(Console.ReadLine());
        double komisionna = double.Parse(Console.ReadLine());

        double cenaBitkoin = 1168; //leva
        double cenaIuana = 0.15;  //dolara
        double dolar = 1.76; //leva
        double evro = 1.95; //leva

        double sumBitkoin = bitkoin * cenaBitkoin;
        double sumIuana = (iuana * cenaIuana)*dolar; //leva

        double sumEvro = (sumBitkoin + sumIuana) / evro; //evro
        double sumKomisionna = sumEvro/(1 / komisionna * 100);
        Console.WriteLine(sumEvro-sumKomisionna);

    }
}

