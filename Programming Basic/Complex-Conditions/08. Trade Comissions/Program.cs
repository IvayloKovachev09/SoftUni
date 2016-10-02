using System;

    class Program
    {
        static void Main()
        {
            var city = Console.ReadLine().ToLower();
            double sale = double.Parse(Console.ReadLine());
            double comission = -1.0;

            if (sale >= 0 && sale <=500)
            {
                if (city == "sofia")
                {
                    comission = 0.05;  
                }
                else if (city =="varna")
                {
                    comission = 0.045;
                }
                else if (city == "plovdiv")
                {
                    comission = 0.055;
                }
            }
            else if (sale >500 && sale <= 1000)
            {
                if (city == "sofia")
                {
                    comission = 0.07;
                }
                else if (city == "varna")
                {
                    comission = 0.075;
                }
                else if (city == "plovdiv")
                {
                    comission = 0.08;
                }
            }
            else if (sale > 1000 && sale <= 10000)
            {
                if (city == "sofia")
                {
                    comission = 0.08;  
                }
                else if (city =="varna")
                {
                    comission = 0.1;
                }
                else if (city == "plovdiv")
                {
                    comission = 0.12;
                }
            }
            else if (sale > 10000)
	            {
		             if (city == "sofia")
                {
                    comission = 0.12;  
                }
                else if (city =="varna")
                {
                    comission = 0.13;
                }
                else if (city == "plovdiv")
                {
                    comission = 0.145;
                }
	        }
            if (comission > -1.0 )
            {
                Console.WriteLine("{0:f2}", (comission * sale));
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }

