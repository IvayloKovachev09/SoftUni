﻿using System;

class Program
{
    static void Main()
    {
        string firstName = Console.ReadLine();
        string secondName = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine($"Hello {firstName} {secondName}. You are {age} years old.");


    }
}

