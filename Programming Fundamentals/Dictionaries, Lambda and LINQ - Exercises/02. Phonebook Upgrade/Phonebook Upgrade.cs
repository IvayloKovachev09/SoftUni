using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Phonebook_Upgrade
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> phonebookIn = new Dictionary<string, string>();
            var phonebook = Console.ReadLine().Split(' ').ToArray();
            while (!phonebook[0].Equals("END"))
            {

                string command = phonebook[0];
                if (command.Equals("A"))
                {
                    AddToDictionary(phonebookIn, phonebook);

                }
                else if (command.Equals("S"))
                {
                    PrintPhone(phonebookIn, phonebook);

                }
                else if (command.Equals("ListAll"))
                {
                    PrintAllPhone(phonebookIn);
                }
                phonebook = Console.ReadLine().Split(' ').ToArray();
                
            }

        }

        private static void PrintAllPhone(Dictionary<string, string> phonebookIn)
        {
            foreach ( var result in phonebookIn.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{result.Key} -> {result.Value}");
            }
        }

        private static void PrintPhone(Dictionary<string, string> phonebookIn, string[] phonebook)
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

        private static void AddToDictionary(Dictionary<string, string> phonebookIn, string[] phonebook)
        {
            string name = phonebook[1];
            string number = phonebook[2];
            phonebookIn[name] = number;
        }
    }
}
