using System;

    class Program
    {
        static void Main()
        {
            string s = Console.ReadLine().ToLower();
            string result = "";
            if (s == "banana" || s == "apple" || s == "kiwi" || s == "cherry" || s == "lemon" || s == "grapes")
                result = "fruit";
            else if (s == "tomato" || s == "cucumber" ||    s == "pepper" || s == "carrot")
            {
                result = "vegetable";
            }
            else
            {
                result = "unknown";
            }
            Console.WriteLine(result);
        }
    }

