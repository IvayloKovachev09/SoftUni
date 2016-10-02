using System;

class Program
{
    static void Main()
    {
        int km = int.Parse(Console.ReadLine());
        string dayNight = Console.ReadLine();

        if (km<20)
        {
            if (dayNight == "night")
            {
                Console.WriteLine(km*0.90+0.7);
            }
            else if (dayNight == "day")
            {
                Console.WriteLine(km*0.79+0.7);
            }
        }
        else if (km>=20 && km<100)
        {
           
            Console.WriteLine(km * 0.09);
           
        }
        else if (km>=100)
        {
            Console.WriteLine(km*0.06);
        }
    }
}

