using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ParkingSistem
{
    public static void Main()
    {
        Dictionary<int, HashSet<int>> parking = new Dictionary<int, HashSet<int>>();
        int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int totalRows = data[0];
        int totalCols = data[1];
        string input = Console.ReadLine();

        while (!input.Equals("stop"))
        {
            string[] dataCarForPark = input.Split();
            int entryRow = int.Parse(dataCarForPark[0]);
            int targetRow = int.Parse(dataCarForPark[1]);
            int targetCol = int.Parse(dataCarForPark[2]);

            if (!IsPlaceOccupate(parking, targetRow, targetCol))
            {
                OccupatePlace(parking, targetRow, targetCol);
                int distance = Math.Abs(entryRow - targetRow);
                distance += targetCol + 1;
                Console.WriteLine(distance);
            }

            else
            {
                targetCol = TryFindEmptySpace(parking[targetRow], totalCols, targetCol);
                if (targetCol==0)
                {
                    Console.WriteLine($"Row {targetRow} full");
                }
                else
                {
                    OccupatePlace(parking, targetRow, targetCol);
                    int distance = Math.Abs(entryRow - targetRow);
                    distance += targetCol + 1;
                    Console.WriteLine(distance);
                }
            }
            input = Console.ReadLine();
        }
    }
    private static int TryFindEmptySpace(HashSet<int> hashset, int totalNumbersOfCols, int targetCol)
    {
        int targetColIndex = 0;
        int minDistance = int.MaxValue;
        if (hashset.Count == totalNumbersOfCols - 1)
        {
            return targetColIndex;
        }
        else
        {
            for (int i = 1; i < totalNumbersOfCols; i++)
            {
                int currentDistance = Math.Abs(targetCol - i);
                if (!hashset.Contains(i) && currentDistance < minDistance)
                {
                    targetColIndex = i;
                    minDistance = currentDistance;
                }
            }
            return targetColIndex;
        }
    }
    public static bool IsPlaceOccupate(Dictionary<int, HashSet<int>> parking, int targetRow, int targetCol)
    {
        return parking.ContainsKey(targetRow) && parking[targetRow].Contains(targetCol);
    }
    public static void OccupatePlace(Dictionary<int, HashSet<int>> parking, int targetRow, int targetCol)
    {
        if (!parking.ContainsKey(targetRow))
        {
            parking.Add(targetRow, new HashSet<int>());
        }
        parking[targetRow].Add(targetCol);
    }
}

