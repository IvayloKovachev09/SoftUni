using System;

public class Program
{
    public static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        long digit =Math.Abs( number % 10);
        string s = digit.ToString();
        Console.WriteLine(LastDigit(s));
    }    
    public static string LastDigit(string s)
    {
        long number = int.Parse(s);
        
        if (number==0)
        {
            s="zero";
        }
        else if (number == 1)
        {
            s = "one";
        }
        else if (number == 2)
        {
            s = "two";
        }
        else if (number == 3)
        {
            s = "three";
        }
        else if (number == 4)
        {
            s = "four";
        }
        else if (number == 5)
        {
            s = "five";
        }
        else if (number == 6)
        {
            s = "six";
        }
        else if (number == 7)
        {
            s = "seven";
        }
        else if (number == 8)
        {
            s = "eight";
        }
        else if (number == 9)
        {
            s = "nine";
        }
        return s;
    }
}
    


