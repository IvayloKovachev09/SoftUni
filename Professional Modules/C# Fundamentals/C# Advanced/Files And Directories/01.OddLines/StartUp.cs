using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class StartUp
{
    static void Main()
    {
        string outputPath = @"C:\Users\Ivaylo\Desktop\Foot\Files And Directories\01.OddLines\OutputPath\Outpus.txt";
        string inputPath = @"C:\Users\Ivaylo\Desktop\Foot\Files And Directories\01.OddLines\bin\Debug\01_LinesOut.txt";

        StreamReader reader = File.OpenText(inputPath);
        var writer = File.AppendText(outputPath);

        using (reader)
        {
            using (writer)
            {
                string line = reader.ReadLine();
                int counter = 0;
                while (line != null)
                {
                    if (counter%2 !=0)
                    {
                        writer.WriteLine(line);
                    }
                    counter++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}

