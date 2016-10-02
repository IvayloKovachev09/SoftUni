using System;

public class Program
{
    public static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        char firstChar = (char)firstNumber;
        char secondChar = (char)secondNumber;

        for (char c = firstChar; c <= secondChar; c++)
        {
            Console.Write("{0} ",c); ;
            
        }
       
    }
}

