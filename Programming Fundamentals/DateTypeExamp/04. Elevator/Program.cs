using System;
    class Program
{
    static void Main()
    {
        int hora = int.Parse(Console.ReadLine());
        int horaKursAsanscor = int.Parse(Console.ReadLine());

        double kursa =Math.Ceiling((double)hora / horaKursAsanscor);
        Console.WriteLine(kursa);
    }
}

