using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
        {
        var input = Console.ReadLine().ToArray();
            
            Array.Reverse(input);
            Console.WriteLine(input);
        }
    }
}
