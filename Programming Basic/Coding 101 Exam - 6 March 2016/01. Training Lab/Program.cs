using System;

class Program
{
    static void Main()
    {
        double dyljina = double.Parse(Console.ReadLine());
        double shirochina = double.Parse(Console.ReadLine());

        double dyljinaSm = dyljina * 100;
        double shirochinaSm = shirochina * 100;

        double shirochinaStolove = Math.Floor((shirochinaSm - 100)/70);
        double dyljinaStolove = Math.Floor(dyljinaSm/120);
        double broiStolove = shirochinaStolove * dyljinaStolove - 3;
        Console.WriteLine(broiStolove);

    }
}

