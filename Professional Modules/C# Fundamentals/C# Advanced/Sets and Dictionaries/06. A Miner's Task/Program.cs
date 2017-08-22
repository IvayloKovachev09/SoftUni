using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.A_Miner_s_Task
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, int> miner = new Dictionary<string, int>();
            string input = Console.ReadLine();
            //int count = 1;
            while (input!="stop")
            {
                int number = int.Parse(Console.ReadLine());
                if (miner.ContainsKey(input))
                {
                    miner[input] += number;
                }
                else
                {
                    miner.Add(input,number);
                }
                input = Console.ReadLine();
            }
            foreach (var item in miner)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
