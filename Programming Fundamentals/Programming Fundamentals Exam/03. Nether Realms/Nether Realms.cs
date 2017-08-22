using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Nether_Realms
{
    class Program
    {
        static void Main()
        {
            var inputDemons = Console.ReadLine().Split(new char[] { ',' },StringSplitOptions.RemoveEmptyEntries).ToArray();

         
            for (int i = 0; i < inputDemons.Length; i++)
            {
                string[] players = inputDemons[i].Split(new char[] { '+', '-', '*', '/' }, StringSplitOptions.RemoveEmptyEntries);
                
                Regex re = new Regex(@"[a-zA-Z]+\d+");
                Match result = re.Match(players);

                string alphaPart = result.Groups[1].Value;
                string numberPart = result.Groups[2].Value;




            }
            
        }
    }
}
