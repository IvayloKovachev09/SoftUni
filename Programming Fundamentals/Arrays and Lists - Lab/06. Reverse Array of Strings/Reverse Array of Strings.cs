using System;

public class Program
{
    public static void Main()
    {
        string character = Console.ReadLine();
        string[] charac = character.Split(' ');
        string[] reverceChar = new string[charac.Length];

        for (int i = 0; i < charac.Length; i++)
        {
            reverceChar[i] = charac[i];
            
        }
        Array.Reverse(reverceChar);
        for (int i = 0; i < reverceChar.Length; i++)
        {
            Console.Write("{0} ",reverceChar[i]);
        }
    }
}

