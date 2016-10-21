using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal sumCounter = 0;
            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                decimal daysInMonth = DateTime.DaysInMonth(date.Year,date.Month);
                decimal capsulesCount = decimal.Parse(Console.ReadLine());

                decimal sumPrice = ((daysInMonth * capsulesCount) * pricePerCapsule);
                Console.WriteLine("The price for the coffee is: ${0:f2}",sumPrice);
                sumCounter += sumPrice;
            }
            Console.WriteLine("Total: ${0:f2}",sumCounter);   
        }
    }
}
