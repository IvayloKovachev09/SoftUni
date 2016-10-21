using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Command_Interpreter
{
    class Program
    {
        static void Main()
        {
            string[] number = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] commands = Console.ReadLine().Split().ToArray();
            while (!commands.Equals("end"))
            {
                         
                List<string> reverseNumber = new List<string>();
                for (int i = 0; i < number.Length; i++)
                {
                    reverseNumber.Add(number[i]);
                }
                
                if (commands[0].Equals("reverse"))
                {
                    int start = int.Parse(commands[2]);
                    int count = int.Parse(commands[4]);
                    reverseNumber.Reverse(start, count);
                    string output = string.Join(", ",reverseNumber.ToArray());
                    Console.WriteLine("[{0}]",output);
                }
                else if (commands[0].Equals("sort"))
                {
                    int start = int.Parse(commands[2]);
                    int count = int.Parse(commands[4]);

                  var sortedList= reverseNumber.Skip(start).Take(count).OrderBy(str => str).ToArray();
                    sortedList.RemoveRange
                    string output = string.Join(", ", reverseNumber.ToArray());
                    Console.WriteLine("[{0}]", output);
                }
                else
                {
                    Console.WriteLine("Invalid input parameters.");
                }
                commands = Console.ReadLine().Split().ToArray();
            }

        }
    }
}
