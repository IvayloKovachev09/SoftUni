using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Text_Filter
{
    class Program
    {
        static void Main()
        {
        
            var banWords = Console.ReadLine().Split(new char[] { ' ', ',' },StringSplitOptions.RemoveEmptyEntries).ToArray();
            string text = Console.ReadLine();

            foreach (string word in banWords)
            {
                    text =text.Replace(word,new string('*',word.Length));               
            }
            Console.WriteLine(text);
        }
    }
}
