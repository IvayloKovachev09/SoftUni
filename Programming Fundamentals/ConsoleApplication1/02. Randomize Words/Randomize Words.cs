using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Randomize_Words
{
    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split(' ');
            Random rnd = new Random();
            for (int ind1 = 0; ind1 < words.Length; ind1++)
            {
                int ind2 = rnd.Next(words.Length);
                string todo = words[ind1];
                words[ind1] = words[ind2];
                words[ind2] = todo;
            }

            Console.WriteLine(string.Join("\r",words));
        }
    }
}
