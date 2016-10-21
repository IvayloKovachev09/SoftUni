using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_Substring_Occurrences
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine().ToLower();
            string patern = Console.ReadLine().ToLower();
            int counter = 0;
            int index = text.IndexOf(patern);
            while (index!=-1)
            {
                counter++;
                index = text.IndexOf(patern, index + 1);
            }
            Console.WriteLine(counter);

        }
    }
}
