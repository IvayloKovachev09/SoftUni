using System;

public class Program
{
    public static void Main()
    {
        int distance = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        int seconds = int.Parse(Console.ReadLine());

        float timeSec = (hours * 3600) + (minutes * 60) + (float)seconds;
        float mS =(distance / timeSec);
        float kmH = (distance / 1000.0f) / (timeSec / 3600.0f);
        float mph = kmH / 1.609f;
        Console.WriteLine("{0}",mS);
        Console.WriteLine("{0}",kmH);
        Console.WriteLine("{0}",mph);

    }
}

