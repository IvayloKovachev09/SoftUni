using System;

class Program
{
    static void Main()
    {
        double duljina, shirina, visochina,volume = 0;
        Console.Write("Length: ");
        duljina = double.Parse(Console.ReadLine());
        Console.Write("Width: ");
        shirina = double.Parse(Console.ReadLine());
        Console.Write("Height: ");
        visochina = double.Parse(Console.ReadLine());
        volume = (duljina * shirina * visochina) / 3;
        Console.WriteLine("Pyramid Volume: {0:F2}", volume);

    }
}

