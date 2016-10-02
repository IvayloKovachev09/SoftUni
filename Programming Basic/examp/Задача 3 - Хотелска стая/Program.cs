using System;

class Program
{
    static void Main()
    {
        string mesec = Console.ReadLine();
        int dni = int.Parse(Console.ReadLine());

        if (mesec== "May" || mesec== "October")
        {
            

            if (dni>7 && dni<=14)
            {
                double dayOtsApar = 65 * dni;
                double daysotsSt = (50 - (50 * 0.05)) * dni;
                Console.WriteLine("Apartment: {0:f2} lv.", dayOtsApar);
                Console.WriteLine("Studio: {0:f2} lv.", daysotsSt);
            }
            else if (dni>14)
            {
                double dayOtsApar = (65-(65*0.1))*dni;
                double daysotsSt = (50 - (50 * 0.3)) * dni;
                Console.WriteLine("Apartment: {0:f2} lv.", dayOtsApar);
                Console.WriteLine("Studio: {0:f2} lv.", daysotsSt);
            }
            else
            {
                Console.WriteLine("Apartment: {0:f2} lv.", dni*65);
                Console.WriteLine("Studio: {0:f2} lv.", dni*50);
            }
        }

        if (mesec == "June" || mesec == "September")
        {


            if (dni <= 14)
            {
                double dayOtsApar = 68.70 * dni;
                double daysotsSt = 75.20 * dni;
                Console.WriteLine("Apartment: {0:f2} lv.", dayOtsApar);
                Console.WriteLine("Studio: {0:f2} lv.", daysotsSt);
            }
            else if (dni > 14)
            {
                double dayOtsApar = (68.7 - (68.7 * 0.1)) * dni;
                double daysotsSt = (75.2 - (75.2 * 0.2)) * dni;
                Console.WriteLine("Apartment: {0:f2} lv.", dayOtsApar);
                Console.WriteLine("Studio: {0:f2} lv.", daysotsSt);
            }
           
        }
        if (mesec == "July" || mesec == "August")
        {


            if (dni <= 14)
            {
                double dayOtsApar = 77 * dni;
                double daysotsSt = 76 * dni;
                Console.WriteLine("Apartment: {0:f2} lv.", dayOtsApar);
                Console.WriteLine("Studio: {0:f2} lv.", daysotsSt);
            }
            else if (dni > 14)
            {
                double dayOtsApar = (77 - (77 * 0.1)) * dni;
                double daysotsSt = 76 * dni;
                Console.WriteLine("Apartment: {0:f2} lv.", dayOtsApar);
                Console.WriteLine("Studio: {0:f2} lv.", daysotsSt);
            }

        }
    }
}

