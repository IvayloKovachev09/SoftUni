using System;

public class Program
{
    public static void Main()
    {
        string figureType = Console.ReadLine();
        if (figureType == "triangle" || figureType == "rectangle")
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2}",AreaFigureTriangleOrRectagle(a,b,figureType));

        }
        else 
        {
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2}",AreaFigureSquareOrCircle(c, figureType));
        }


    }
    public static double AreaFigureTriangleOrRectagle(double a,double b,string figureType)
    {
        double result = 0;
        if (figureType == "triangle")
        {
            result = a * b / 2;
        }
        else if (figureType== "rectangle")
        {
            result = a * b;
        }
        return result;
    }
    public static double AreaFigureSquareOrCircle(double c, string figureType)
    {
        double result = 0;
        if (figureType == "square")
        {
            result = Math.Pow(c,2);
        }
        else if (figureType == "circle")
        {
            result = Math.PI*(Math.Pow(c,2));
        }
        return result;
    }
}

