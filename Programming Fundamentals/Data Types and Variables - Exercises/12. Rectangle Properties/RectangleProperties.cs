using System;

public class Program
{
    public static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double hight = double.Parse(Console.ReadLine());
        double perimeter = (2 * width) + (2 * hight);
        double area = width * hight;
        double diagonal = Math.Sqrt((width*width)+(hight*hight));
        Console.WriteLine(perimeter);
        Console.WriteLine(area);
        Console.WriteLine(diagonal);


    }
}

