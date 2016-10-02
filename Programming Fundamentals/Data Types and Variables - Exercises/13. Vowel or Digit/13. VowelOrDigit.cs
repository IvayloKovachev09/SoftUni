using System;

public class Program
{
    public static void Main()
    {
        char simbol = char.Parse(Console.ReadLine());

        if (simbol == '0' || simbol == '1' || simbol == '2' || simbol == '3' || simbol == '4' || simbol == '5' || simbol == '6' || simbol == '7' || simbol == '8' || simbol == '9')
        {
            Console.WriteLine("digit");
        }
        else if (simbol == 'a' || simbol == 'e' || simbol == 'i' || simbol == 'o' || simbol == 'u')
        {
            Console.WriteLine("vowel");
        }
        else
        {
            Console.WriteLine("other");
        }

    }
}

