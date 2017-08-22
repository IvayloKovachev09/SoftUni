using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Periodic_Table
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            SortedSet<string> namesFromTable = new SortedSet<string>();

            for (int i = 0; i < number; i++)
            {
                string[] periodic = Console.ReadLine().Split();
                foreach (var item in periodic)
                {
                    namesFromTable.Add(item);
                }
            }
            foreach (var item in namesFromTable)
            {
                Console.Write($"{item} ");
            }
        }
    }







}
