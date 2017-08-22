using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Count_Symbols
{
    public class Count_Symbols
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            SortedDictionary<char, int> dict = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentSimbol = input[i];
                if (!dict.ContainsKey( currentSimbol))
                {
                    dict[currentSimbol] = 1;
                }
                else
                {
                    dict[currentSimbol]++;
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");

            }
        }
    }
}
