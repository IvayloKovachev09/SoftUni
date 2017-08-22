using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int numberOfStation = int.Parse(Console.ReadLine());
        Queue<GasPump> pumps = new Queue<GasPump>();
        for (int i = 0; i < numberOfStation; i++)
        {
            string[] pumpInfo = Console.ReadLine().Split();
            int distanceToNext = int.Parse(pumpInfo[1]);
            int amountOfGas = int.Parse(pumpInfo[0]);

            GasPump pump = new GasPump(distanceToNext, amountOfGas,i);
            pumps.Enqueue(pump);
        }
        GasPump startOfPump = null;
        bool hasCompleteJourney = false;
        while (true)
        {
  
            GasPump currentPump = pumps.Dequeue();
            pumps.Enqueue(currentPump);
            startOfPump = currentPump;
            int gasOfTank = currentPump.amountOfGas;
            while (gasOfTank>=currentPump.distanceToNext)
            {
                gasOfTank -= currentPump.distanceToNext;
                currentPump = pumps.Dequeue();
                pumps.Enqueue(currentPump);
                if (currentPump == startOfPump)
                {
                    hasCompleteJourney = true;
                    break;
                }
                gasOfTank += currentPump.amountOfGas;
            }
            if (hasCompleteJourney)
            {
                Console.WriteLine(currentPump.indexOfPump);
                break;
            }
        }  
    }
}
public class GasPump
{
    public int distanceToNext;
    public int amountOfGas;
    public int indexOfPump;

    public GasPump(int distanceToNext, int amountOfGas, int indexOfPump)
    {
        this.distanceToNext = distanceToNext;
        this.amountOfGas = amountOfGas;
        this.indexOfPump = indexOfPump;

    }
}


