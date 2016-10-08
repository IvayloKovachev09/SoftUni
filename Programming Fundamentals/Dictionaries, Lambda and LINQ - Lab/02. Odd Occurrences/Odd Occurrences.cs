using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main()
        {
            var words = Console.ReadLine().ToLower().Split(' ').ToArray();
            var counts = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts[word] = 1;
                }
            }
            var result = new List<string>();
            foreach (var res in counts)
            {
                if (res.Value%2 !=0)
                {
                    result.Add(res.Key);
                   
                }
            }
            Console.WriteLine(string.Join(", ", result));

        }
    }
}
