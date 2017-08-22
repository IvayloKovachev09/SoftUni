using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    static void Main()
    {
        SortedDictionary<string, Dictionary<string, int>> logsByUser = new SortedDictionary<string, Dictionary<string, int>>();
        string input = Console.ReadLine();

        while (!input.Equals("end"))
        {
            string[] logInfo = input.Split();
            string[] iPInfo = logInfo[0].Split('=');
            string iP =iPInfo[1];
            string[] userinfo = logInfo[2].Split('=');
            string user = userinfo[1];

            if (!logsByUser.ContainsKey(user))
            {
                logsByUser.Add(user,new Dictionary<string, int>());
                logsByUser[user].Add(iP, 0);
            }
            else if (!logsByUser[user].ContainsKey(iP))
            {
                logsByUser[user].Add(iP,0);
            }
            logsByUser[user][iP]++;

            input = Console.ReadLine();
        }
        foreach (var outerPair in logsByUser)
        {

            Console.WriteLine($"{outerPair.Key}:");
            Console.WriteLine("{0}.",string.Join(", ",outerPair.Value.Select( x=>$"{x.Key} => {x.Value}")));
        }
    }
}

