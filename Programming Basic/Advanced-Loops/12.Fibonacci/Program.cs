﻿using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int a = 1;
        int b = 1;
        for (int i = 0; i < n-1; i++)
        {
            var sum = a + b;
            b = a;
            a = sum;
        }
        Console.WriteLine(a);
    }
}

