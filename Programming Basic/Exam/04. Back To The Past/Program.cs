using System;

class Program
{
    static void Main()
    {
        double money = double.Parse(Console.ReadLine());
        int years = int.Parse(Console.ReadLine());
       
        for (int i = 1800; i <= years; i++)
        {
            int yearsOld = 18 + (i - 1800);


            if (i%2==0)
            {
                money -= 12000;
            }
            else
            {
                money -= 12000 + 50 * yearsOld;
            }
        }
        if (money>=0)
        {
            Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.",money);
        }
        else
        {
            Console.WriteLine("He will need {0:f2} dollars to survive.",Math.Abs( money));
        }
    }
}

