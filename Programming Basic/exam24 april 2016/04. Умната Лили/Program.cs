using System;

class Program
{
    static void Main()
    {
        int age = int.Parse(Console.ReadLine());
        double priceToWashing = double.Parse(Console.ReadLine());
        int priceToToy = int.Parse(Console.ReadLine());

        int sumPriceToToy = 0;
        int sumLeva = 0;
        int sumSum = 0;
        for (int i = 1; i <= age; i++)
        {
            if (i%2==0)
            {
                    sumLeva += 10;
                    sumSum += sumLeva;
            }
            else
            {
                sumPriceToToy += priceToToy;
            }
        }
        double sumToLeva = sumSum + sumPriceToToy-age/2;
        if (priceToWashing<=sumToLeva)
        {
            double razlika = sumToLeva-priceToWashing;
            Console.WriteLine("Yes! {0:f2}", razlika);
        }
        else
        {
            double razlika = priceToWashing - sumToLeva;
            Console.WriteLine("No! {0:f2}",Math.Abs( razlika));
        }
    }
}

