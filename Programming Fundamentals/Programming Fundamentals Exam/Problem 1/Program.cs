using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Program
    {
        static void Main()
        {
            int day = int.Parse(Console.ReadLine());
            int runnersCount = int.Parse(Console.ReadLine());
            int averagNumberOfLaps = int.Parse(Console.ReadLine());
            double lengthTrack = double.Parse(Console.ReadLine());
            int capacityTrack = int.Parse(Console.ReadLine());
            decimal moneyPerKilometer = decimal.Parse(Console.ReadLine());

            int runnersPerDay = day * capacityTrack;
            if (runnersPerDay>= runnersCount)
            {
                double totalKm = (runnersCount * averagNumberOfLaps * lengthTrack)/1000;
                decimal moneyMarathon = (decimal)totalKm * moneyPerKilometer;
                Console.WriteLine("Money raised: {0:f2}",moneyMarathon);
            }
            else
            {
                double totalKm = (runnersPerDay * averagNumberOfLaps * lengthTrack) / 1000;
                decimal moneyMarathon = (decimal)totalKm * moneyPerKilometer;
                Console.WriteLine("Money raised: {0:f2}", moneyMarathon);
            }

        }
    }
}
