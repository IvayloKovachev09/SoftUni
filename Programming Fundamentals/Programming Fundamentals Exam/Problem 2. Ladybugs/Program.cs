using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Ladybugs
{
    class Program
    {
        static void Main()
        {
            int sizeField = int.Parse(Console.ReadLine());
            var numberOfIndex = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var commands = Console.ReadLine().Split().ToArray();

            int countStart = int.Parse(commands[0]);
            string leftRight = commands[1];
            int move = int.Parse(commands[2]);

          
            List<bool> list = new List<bool>();
            for (int i = 0; i < sizeField; i++)
            {
                if (numberOfIndex[i]>=0)
                {
                    list.Add(true);
                }
                
            }
         
            while (!commands.Equals("end"))
            {
                if (leftRight.Equals("right"))
                {
                    list.Take(countStart);
                    
                }
            }

        }
    }
}
