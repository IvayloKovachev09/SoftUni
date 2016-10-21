using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Merge_Files
{
    class Program
    {
        static void Main()
        {
            string[] fileOne = File.ReadAllText("FileOne.txt").Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] fileTwo = File.ReadAllText("FileTwo.txt").Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> concate = new List<string>();
            foreach (string add in fileOne)
            {
                concate.Add(add);
            }
            foreach (string add in fileTwo)
            {
                concate.Add(add);
            }
            concate = concate.OrderBy(x=>x).ToList();
            File.WriteAllText("output.txt","");
            foreach (string go in concate)
            {
                File.AppendAllText("output.txt",go+"\r\n");

            }


        }
    }
}
