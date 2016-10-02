using System;

    class Program
    {
        static void Main()
        {
            double num = double.Parse(Console.ReadLine());
            var gardner = Console.ReadLine();
            if (num >=16)
            {
                if (gardner == "m")
                    Console.WriteLine("Mr.");
                
                else if (gardner == "f")
                    Console.WriteLine("Ms.");
                
            }
            else
            {
                if (gardner == "f")
                    Console.WriteLine("Miss");
              
                else if(gardner == "m")
                    Console.WriteLine("Master");
            }

        }
    }

