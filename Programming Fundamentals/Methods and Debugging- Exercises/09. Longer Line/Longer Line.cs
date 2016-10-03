using System;

public class Program
{
    public static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());

        GetPointNearToZero( x,y,x1,y1,x2,y2,x3,y3);
        
    }
    public static void GetPointNearToZero(double x,double y,double x1, double y1,double x2,double y2,double x3,double y3)
    {
        double distanceBetweenToTwoPointsA = GetDistanceBetweenTwoPoints(x, y, x1, y1);
        double distanceBetweenToTwoPointsB = GetDistanceBetweenTwoPoints(x2, y2, x3, y3);
        if (distanceBetweenToTwoPointsA < distanceBetweenToTwoPointsB)
        {
            double distanceToCenterC = GetDistanceBetweenTwoPoints(x2, y2, 0, 0);
            double distanceToCenterD = GetDistanceBetweenTwoPoints(x3, y3, 0, 0);
            if (distanceToCenterC > distanceToCenterD)
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x3, y3, x2, y2);
            }
            else
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x2, y2, x3, y3);
            }

        }
        else if(distanceBetweenToTwoPointsA > distanceBetweenToTwoPointsB)
        {
            double distanceToCenterA = GetDistanceBetweenTwoPoints(x, y, 0, 0);
            double distanceToCenterB = GetDistanceBetweenTwoPoints(x1, y1, 0, 0);
            if (distanceToCenterA > distanceToCenterB)
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x1, y1, x, y);
            }
            else
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x, y, x1, y1);
            }
        }
        else
        {
            Console.WriteLine("({0}, {1})({2}, {3})", x, y, x1, y1);
        }
    }
        
    
    public static double GetDistanceBetweenTwoPoints(double a, double b, double a1, double b1)
    {
        double distance = Math.Sqrt(Math.Pow((a - a1), 2) + Math.Pow((b - b1), 2));
        return distance;
    }
}

