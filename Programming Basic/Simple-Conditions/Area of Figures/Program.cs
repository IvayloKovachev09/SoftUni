using System;

    class Program
    {
        static void Main()
        {
            var word = Console.ReadLine();
            var a = double.Parse(Console.ReadLine());
            
            if (word == "square")
            {
                var c = (Math.Pow(a,2));
                Console.WriteLine(Math.Round(c,3));
            }
            else if (word == "circle")
            {
                var c = Math.PI*(Math.Pow(a,2));
                Console.WriteLine(Math.Round(c, 3));
            }
            else if (word == "rectangle")
            {
                var b = double.Parse(Console.ReadLine());
                var c = a * b;
                Console.WriteLine(Math.Round(c,3));
            }
            else if (word == "triangle")
            {
                var b = double.Parse(Console.ReadLine());
                var c = (a * b)/2;
                Console.WriteLine(Math.Round(c,3)); 
            }
           
        }
    }

