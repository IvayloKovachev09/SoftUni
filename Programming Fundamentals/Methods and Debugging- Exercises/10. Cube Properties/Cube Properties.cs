using System;

public class Program
{
    public static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        string parameter = Console.ReadLine();
        double result = ReturnLengthDiagonal(number, parameter);
        Console.WriteLine("{0:f2}", result);
    }
    public static double ReturnLengthDiagonal(double number, string parameter)
    {
        double result = 0;
        if (parameter == "face")
        {
            result = Math.Sqrt(2 * Math.Pow(number, 2));
        }
        else if (parameter == "space")
        {
            result = Math.Sqrt(3 * Math.Pow(number, 2));
        }
        else if (parameter == "volume")
        {
            result = Math.Pow(number, 3);
        }
        else if (parameter == "area")
        {
            result = (Math.Pow(number, 2))*6;
        }
        return result;
    }

}



