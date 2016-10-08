using System;

public class Program
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int [] arr = new int[number];
        for (int i = 0; i < number; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = number-1; i >=0; i--)
        {
            Console.WriteLine(arr[i]);
        }

       
    }
}

