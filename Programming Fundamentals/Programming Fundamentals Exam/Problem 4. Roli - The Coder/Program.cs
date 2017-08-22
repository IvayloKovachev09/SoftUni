using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_4.Roli___The_Coder
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var arrayInput = input.Split().ToArray();
            while (!input.Equals("Time for Code"))
            {
                Dictionary < string,string> dict = new Dictionary<string,string>();
                Regex reg = new Regex(@"(\d+) (#[A-Z][a-z]+) (@[a-z]+)");
                Match match = reg.Match(input);
                int count = 0;
                for (int i = 0; i < arrayInput.Length-2; i++)
                {
                    count++;
                }
                string key = match.Groups[1];
                var value = match.Groups[2];
                if (dict.ContainsKey(key))
                {
                    dict[key] = value;
                }
                else
                {
                    dict.Add(key, value);
                }

            }

            input = Console.ReadLine();
           

        }
    }
}
