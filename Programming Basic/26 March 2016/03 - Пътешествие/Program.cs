using System;

class Program
{
    static void Main()
    {
        double buget = double.Parse(Console.ReadLine());
        string sezon = Console.ReadLine();

        if (buget <= 100)
        {
            Console.WriteLine("Somewhere in Bulgaria");
            if (sezon == "summer")
            {
                double poharchenaSuma = (buget / 100) * 30;
                Console.WriteLine("Camp - {0:f2}", poharchenaSuma);
            }
            else if (sezon == "winter")
            {
                double poharchenaSuma = (buget / 100) * 70;
                Console.WriteLine("Hotel - {0:f2}", poharchenaSuma);
            }

        }
        else if (buget <= 1000 && buget > 100)
        {
            Console.WriteLine("Somewhere in Balkans");
            if (sezon == "summer")
            {
                double poharchenaSuma = (buget / 100) * 40;
                Console.WriteLine("Camp - {0:f2}", poharchenaSuma);
            }
            else if (sezon == "winter")
            {
                double poharchenaSuma = (buget / 100) * 80;
                Console.WriteLine("Hotel - {0:f2}", poharchenaSuma);
            }
        }
        else if ( buget > 1000)
        {
                Console.WriteLine("Somewhere in Europe");
                double poharchenaSuma = (buget / 100) * 90;
                Console.WriteLine("Hotel - {0:f2}", poharchenaSuma);
            
        }
    }
}

