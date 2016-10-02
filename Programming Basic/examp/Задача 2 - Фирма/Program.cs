using System;

class Program
{
    static void Main()
    {
        int neobhodimiChasove = int.Parse(Console.ReadLine());
        int dniProect = int.Parse(Console.ReadLine());
        int slujiteli = int.Parse(Console.ReadLine());

        double rabotniChasa = 8*(dniProect-(dniProect*0.1));
        int slujiteliInzvarednoRabota = slujiteli*(2*dniProect);
        double obshtoChasove =Math.Floor (rabotniChasa + slujiteliInzvarednoRabota);
        if (obshtoChasove>=neobhodimiChasove)
        {
            Console.WriteLine("Yes!{0} hours left.",obshtoChasove-neobhodimiChasove);
        }
        else
        {
            Console.WriteLine("Not enough time!{0} hours needed.", neobhodimiChasove-obshtoChasove);
        }
    }
}

