using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sets_of_Elements
{
    public class Program
    {
        public static void Main()
        {
            string[] numberSet = Console.ReadLine().Split();
            int firstSetCount = int.Parse(numberSet[0]);
            int secondSetCount = int.Parse(numberSet[1]);
            HashSet<int> hashSpecialNumbersFirst = new HashSet<int>();
            HashSet<int> hashSpecialNumbersSecond = new HashSet<int>();

            for (int i = 0; i < firstSetCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                hashSpecialNumbersFirst.Add(number);
            }

            for (int i = 0; i < secondSetCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                hashSpecialNumbersSecond.Add(number);
            }
            foreach (var item in hashSpecialNumbersFirst)
            {
                if (hashSpecialNumbersSecond.Contains(item))
                {
                    Console.Write($"{item} ");
                }
            }
        }
    }
}
