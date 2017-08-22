using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FixEmails
{
    public static void Main()
    {
        Dictionary<string, string> nameEmail = new Dictionary<string, string>();

        string inputName = Console.ReadLine();

        while (inputName != "stop")
        {
            string[] inputEmail = Console.ReadLine().Split('.');
            if (inputEmail[1]!="us" && inputEmail[1]!="uk")
            {
                string concatInputEmail = inputEmail[0] +'.'+ inputEmail[1];
                if (nameEmail.ContainsKey(inputName))
                {
                    nameEmail[inputName] = concatInputEmail;
                }
                else
                {
                    nameEmail.Add(inputName,concatInputEmail);
                }
            }
            inputName = Console.ReadLine();
        }
        foreach (var item in nameEmail)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}

