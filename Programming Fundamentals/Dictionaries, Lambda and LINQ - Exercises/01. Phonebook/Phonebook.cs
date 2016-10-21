using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> phonebookIn = new Dictionary<string, string>();
            var phonebook = Console.ReadLine().Split(' ').ToArray();
            while (! phonebook[0].Equals("END"))
            {

                string command = phonebook[0];
                if (command.Equals("A"))
                {
                    string name = phonebook[1];
                    string number = phonebook[2];
                    phonebookIn[name] = number;

                }
                else if (command.Equals("S"))
                {
                    string name = phonebook[1];
                    if (phonebookIn.ContainsKey(name))
                    {
                        Console.WriteLine("{0} -> {1}", name, phonebookIn[name]);
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                   
                }
                phonebook = Console.ReadLine().Split(' ').ToArray();
            }
           
        }
    }
}
