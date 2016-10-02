using System;

    class Program
    {
        static void Main()
        {
            var day = Console.ReadLine();
            int prazniciNeSaSabota = int.Parse(Console.ReadLine());
            int uikendRodenGrad = int.Parse(Console.ReadLine());

            double uikendIgriSofia = 48 - uikendRodenGrad;
            double result = (2.0 / 3.0 )* prazniciNeSaSabota;
            double sabotniIgri =uikendIgriSofia * (3.0 /4.0);
            double obshtoIgri = sabotniIgri + result+uikendRodenGrad;
            if (day == "leap")
            {
                Console.WriteLine(Math.Truncate((0.15 * obshtoIgri)+obshtoIgri)); 
            }
            else
            {
                Console.WriteLine(Math.Truncate(sabotniIgri + uikendRodenGrad+result));   
            }
            
        }
    }

