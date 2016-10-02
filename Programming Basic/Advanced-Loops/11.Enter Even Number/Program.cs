using System;

class Program
{
    static void Main()
    {
        
            while (true)
            {
            try
            {
                Console.Write("Enter even number: ");
                int n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    Console.WriteLine("Even number entered: " + n);
                    break;
                }
                Console.WriteLine("The number is not even.");


            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Number");


            }
        }
        
    }
}

