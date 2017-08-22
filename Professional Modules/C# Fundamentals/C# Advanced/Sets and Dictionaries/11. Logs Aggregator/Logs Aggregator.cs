using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        SortedDictionary<string,SortedDictionary<SortedSet<string>,int>> dicUserInfo = new SortedDictionary<string, SortedDictionary<SortedSet<string>, int>>();

        string[] informationPerUser = Console.ReadLine().Split();
        string userName = informationPerUser[1];
        int numberOfSesion = int.Parse(informationPerUser[2]);
        string ip = informationPerUser[0];
        dicUserInfo.Add(userName, new SortedDictionary<SortedSet<string>, int>());
        SortedSet<string> setIp = new SortedSet<string>();
        dicUserInfo[informationPerUser[1]].Add(setIp, numberOfSesion);

        for (int i = 0; i < n-1; i++)
        {
            informationPerUser = Console.ReadLine().Split();
            userName = informationPerUser[1];
            numberOfSesion = int.Parse(informationPerUser[2]);
            ip = informationPerUser[0];
            if (dicUserInfo.ContainsKey(userName))
            {
                int existSesion = dicUserInfo[userName].ContainsValue();
                numberOfSesion += existSesion;
                dicUserInfo[userName].Add(setIp,numberOfSesion);
               
            }
        }
        foreach (var item in dicUserInfo)
        {
            Console.WriteLine($"{dicUserInfo[userName]}: {dicUserInfo[userName].ContainsKey()}");
        }
       
    }
}

