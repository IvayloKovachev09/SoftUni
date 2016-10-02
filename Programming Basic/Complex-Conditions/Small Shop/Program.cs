using System;

class Program
{
    static void Main(string[] args)
    {
        var product = Console.ReadLine().ToLower();
        var town = Console.ReadLine().ToLower();
        double quantity = double.Parse(Console.ReadLine());
        if (product == "coffee")
        {
            if (town == "varna")
            {
                Console.WriteLine(quantity * 0.45);
            }
            else if (town == "plovdiv")
            {
                Console.WriteLine(quantity * 0.40);
            }
            else if (town == "sofia")
            {
                Console.WriteLine(quantity * 0.50);
            }
        }
        else if (product == "water")
        {
            if (town == "varna")
            {
                Console.WriteLine(quantity * 0.70);
            }
            else if (town == "plovdiv")
            {
                Console.WriteLine(quantity * 0.70);
            }
            else if (town == "sofia")
            {
                Console.WriteLine(quantity * 0.80);
            }
        }
        else if (product == "beer")
        {
            if (town == "varna")
            {
                Console.WriteLine(quantity * 1.10);
            }
            else if (town == "plovdiv")
            {
                Console.WriteLine(quantity * 1.15);
            }
            else if (town == "sofia")
            {
                Console.WriteLine(quantity * 1.20);
            }
        }
        else if (product == "sweets")
        {
            if (town == "varna")
            {
                Console.WriteLine(quantity * 1.35);
            }
            else if (town == "plovdiv")
            {
                Console.WriteLine(quantity * 1.30);
            }
            else if (town == "sofia")
            {
                Console.WriteLine(quantity * 1.45);
            }
        }
          else if (product == "peanuts")
            {
                if (town == "varna")
                {
                    Console.WriteLine(quantity * 1.55);
                }
                else if (town == "plovdiv")
                {
                    Console.WriteLine(quantity * 1.50);
                }
                else if (town == "sofia")
                {
                    Console.WriteLine(quantity * 1.60);
                }
            }
        
    }
}
    

