using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_method
{
    class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();
           
            if (command.Equals("int"))
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(a, b));
            }
            else if (command.Equals("string"))
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                Console.WriteLine(GetMax(a, b));
            }
            

        }

        private static int GetMax(int first,int second)
        {
           
            int result = Math.Max(first, second);
            return result;
        }
        private static string GetMax(string first, string second)
        {

            int result = Math.Max(int.Parse(first), int.Parse(second));
            return result.ToString();
        }
        //private static string GetMax()
        //{

        //    string result = GetMax(first, second);
        //    return result;
        //}
        //private static char GetMax()
        //{

        //    char result = GetMax(first, second);
        //    return result;
        //}


    }
}
