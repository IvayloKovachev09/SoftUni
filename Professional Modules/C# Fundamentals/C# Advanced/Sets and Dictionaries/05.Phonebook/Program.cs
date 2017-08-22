using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Phonebook
{
    public class Program
    {
        public static object StringSplitOption { get; private set; }

        public static void Main()
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
            string[] namePhone = Console.ReadLine().Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

          
            while (namePhone[0] != "search")
            {
                string name = namePhone[0];
                string phone = namePhone[1];
                if (phonebook.ContainsKey(name))
                {
                    phonebook[name] = phone;
                }
                else
                {
                    phonebook.Add(name, phone);
                }
                namePhone = Console.ReadLine().Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            }
            while (namePhone[0]!="Stop")
            {
                string nameSearch = Console.ReadLine();

                
                    if (phonebook.ContainsKey(nameSearch))
                    {
                        
                            Console.WriteLine($"{nameSearch} -> {phonebook[nameSearch]}");
                        
                    }
                    else if (nameSearch=="stop"|| nameSearch=="Stop")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Contact {nameSearch} does not exist.");
                    }
                
            }
        }
    }
}
