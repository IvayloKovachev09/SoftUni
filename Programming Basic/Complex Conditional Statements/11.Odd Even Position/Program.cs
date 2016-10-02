using System;

class Program
{
   
        static void Main(string[] args)
        {
            var count = double.Parse(Console.ReadLine());
            var OddSum = 0.0;
            var OddMax = double.MinValue;
            var OddMin = double.MaxValue;
            var EvenSum = 0.0;
            var EvenMin = double.MaxValue;
            var EvenMax = double.MinValue;

            for (int i = 1; i <= count; i++)
            {
                var number = double.Parse(Console.ReadLine());

                if (!(i % 2 == 0))
                {

                    OddSum += number;
                    if (number >= OddMax)
                    {
                        OddMax = number;
                    }
                    if (number <= OddMin)
                    {
                        OddMin = number;
                    }
                }
                else if (i % 2 == 0)
                {
                    EvenSum += number;
                    if (number >= EvenMax)
                    {
                        EvenMax = number;
                    }
                    if (number <= EvenMin)
                    {
                        EvenMin = number;
                    }
                }
            }
            if (count == 1)
            {
                Console.WriteLine("OddSum = {0}", OddSum);
                Console.WriteLine("OddMin = {0}", OddMin);
                Console.WriteLine("OddMax = {0}", OddMax);
                Console.WriteLine("EvenSum = 0");
                Console.WriteLine("EvenMin = No");
                Console.WriteLine("EvenMax = No");



            }


            else if (count == 0)
            {
                Console.WriteLine("OddSum = 0");
                Console.WriteLine("OddMin = No");
                Console.WriteLine("OddMax = No");
                Console.WriteLine("EvenSum = 0");
                Console.WriteLine("EvenMin = No");
                Console.WriteLine("EvenMax = No");
            }

            else

            {
                Console.WriteLine("OddSum = {0}", OddSum);
                Console.WriteLine("OddMin = {0}", OddMin);
                Console.WriteLine("OddMax = {0}", OddMax);
                Console.WriteLine("EvenSum = {0}", EvenSum);
                Console.WriteLine("EvenMin = {0}", EvenMin);
                Console.WriteLine("EvenMax = {0}", EvenMax);
            }
        }
}

