using System;

class Program
{
    static void Main()
    {
        double biudjet = double.Parse(Console.ReadLine());
        string bileti = Console.ReadLine();
        int hora = int.Parse(Console.ReadLine());
        double transport;

        if (1<=hora && hora<=4)
        {
            transport = biudjet * 0.75;
        }
        else if (5<=hora && hora<=9)
        {
           transport = biudjet * 0.6;
        }
        else if (10 <= hora && hora <= 24)
        {
            transport = biudjet * 0.5;
        }
        else if (25 <= hora && hora <= 49)
        {
            transport = biudjet * 0.4;
        }
        else 
        {
            transport = biudjet * 0.25;
        }
        double ostatykPari = biudjet - transport;
        double obstoBileti = double.NaN;

        if (bileti== "Normal")
        {
            obstoBileti = 249.99 * hora;
        }
        else if (bileti=="VIP")
        {
            obstoBileti = 499.99 * hora;
        }
        double kopuvaneBileti = ostatykPari - obstoBileti;
        if (ostatykPari>obstoBileti)
        {
            Console.WriteLine("Yes! You have {0:f2} leva left.",kopuvaneBileti);
        }
        else
        {
            Console.WriteLine("Not enough money! You need {0:f2} leva.",Math.Abs(kopuvaneBileti));
        }
    }
}

