using System;

public class Program
{
    public static void Main()
    {
        string veriable = Console.ReadLine();
        if (veriable=="int")
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(a, b));
        }
        else if (veriable == "char")
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(a, b));
        }
        else if(veriable == "string")
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            Console.WriteLine(GetMax(a, b));
        }

    }
  
    public static int GetMax(int a,int b)
    {
        if (a>=b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
    public static char GetMax(char a, char b)
    {
        if ((int) a>=(int) b)
        {
            return a;
        }
        else
        {
           return b;
        }
    }
    public static string GetMax(string a, string b)
    {
        if (a.CompareTo(b)>=0)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

}

