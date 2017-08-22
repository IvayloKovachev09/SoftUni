using System;
using System.Collections.Generic;



public class Program
{
    public static void Main()
    {
        string[] numberSet = Console.ReadLine().Split();
        HashSet<int> firstSet = new HashSet<int>();
        HashSet<int> secondSet = new HashSet<int>();

        int numberCountFirstSet = int.Parse(numberSet[0]);
        int numberCountSecondSet = int.Parse(numberSet[1]);

        for (int i = 0; i < numberCountFirstSet; i++)
        {
            int n = int.Parse(Console.ReadLine());
            firstSet.Add(n);
        }
        for (int i = 0; i < numberCountSecondSet; i++)
        {
            int n = int.Parse(Console.ReadLine());
            secondSet.Add(n);
        }
        foreach (var item in firstSet)
        {
            if (secondSet.Contains(item))
            {
                Console.WriteLine(item);
            }
        }
    }   
}

