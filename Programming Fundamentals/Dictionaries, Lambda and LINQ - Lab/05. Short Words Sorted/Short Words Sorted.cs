using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Short_Words_Sorted
{
    class Program
    {
        static void Main()
        {
            var text = Console.ReadLine().ToLower().Split('.',',',':',';','(',')','[',']','\\','\"','\'','/','!','?',' ').ToArray();

            var result = text.Where(n => n.Length < 5).OrderBy(w => w).Distinct();


            Console.WriteLine(string.Join(",", result));



        }
    }
}
