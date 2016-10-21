using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
        {
            string[] file = File.ReadAllLines("input.txt");
            File.WriteAllText("output.txt","");

            for (int i = 0; i < file.Length; i++)
            {
                if (i%2!=0)
                {
                    File.AppendAllText("output.txt",file[i]+"\r\n");
                }
            }

        }
    }
}
