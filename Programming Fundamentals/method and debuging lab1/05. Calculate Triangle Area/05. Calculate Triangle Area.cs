using System;

public class Program
{
    public static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine(GetTriangleArea(width, height));

    }
    static double GetTriangleArea(double width, double height)
    {
        return width * height / 2;
    }
   

}

