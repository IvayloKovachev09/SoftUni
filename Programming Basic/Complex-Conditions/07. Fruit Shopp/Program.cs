using System;


    class Program
    {
        static void Main()
        {
            var fruit = Console.ReadLine().ToLower();
            var day = Console.ReadLine().ToLower();
            double num = double.Parse(Console.ReadLine());
            string[] dayStr = { "monday", "tuesday", "wednesday", "thursday", "friday", "saturday","sunday" };
            string[] fruitMass = { "banana", "apple", "orange", "grapefruit", "kiwi", "pineapple", "grapes", };
            double[] sed =    {2.50,  1.20,  0.85,  1.45,    2.70,   5.50,   3.85 };
            double[] uikend = { 2.70,	1.25,	0.90,	1.60,	3.00,	5.60,	4.20 };
            var results = Array.IndexOf(dayStr,day);
            var resss = Array.IndexOf(fruitMass,fruit);
            var err = false;
            if (results < 0 || resss < 0)
            {
                err = true;
            }
            if (!err && results >=0 && results <=4)
            {
                Console.WriteLine("{0:f2}", sed[resss] * num);
            }
            else if (!err && results == 5 || results == 6 )
            {
                Console.WriteLine("{0:f2}", (uikend[resss]) * num);
            }
            else 
            {
                Console.WriteLine("error");
            }
        }
    }

