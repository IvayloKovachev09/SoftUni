using System;

class Program
{
    static void Main()
    {
        int bitkoin = int.Parse(Console.ReadLine());
       double iuan = double.Parse(Console.ReadLine());
        double komisionna = double.Parse(Console.ReadLine());

        int edinBitkoin = 1168;
        double ediniuan = 0.15;
        double edindolar = 1.76;
        double evro = 1.95;
        double sum = (edinBitkoin * bitkoin) + ((ediniuan * iuan) * edindolar);
        double sumEvro = sum / 1.95;
        double komis = sumEvro * (komisionna/100);
        Console.WriteLine(sumEvro-komis);
    }
}

