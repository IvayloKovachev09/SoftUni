using System;

public class Program
{
    public static void Main()
    {
        double x =double.Parse(Console.ReadLine());
        double y =double.Parse(Console.ReadLine());
        double x1 =double.Parse(Console.ReadLine());
        double y1 =double.Parse(Console.ReadLine());
        double distanceBetweenToCentarA = GetDistanceBetweenTwoPoints(x, y, 0, 0);
        double distanceBetweenToCentarB = GetDistanceBetweenTwoPoints(x1,y1,0,0);
        if (distanceBetweenToCentarA>=distanceBetweenToCentarB)
        {
            Console.WriteLine("({0}, {1})",x1,y1);
        }
        else
        {
            Console.WriteLine("({0}, {1})", x, y);
        }
    }
    public static double GetDistanceBetweenTwoPoints(double x,double y,double x1,double y1)
    {
        double distance = Math.Sqrt(Math.Pow((x-x1),2)+Math.Pow((y-y1),2));
        return distance;
    }
    
}

