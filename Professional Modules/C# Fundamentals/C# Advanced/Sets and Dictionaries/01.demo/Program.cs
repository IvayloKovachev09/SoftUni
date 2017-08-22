using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        HashSet<string> nameHash = new HashSet<string>();
        for (int i = 0; i < number; i++)
        {
            string name = Console.ReadLine();
            nameHash.Add(name);

        }
        foreach (var item in nameHash)
        {
            Console.WriteLine(item);
        }

    }
}
