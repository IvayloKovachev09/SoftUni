using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var firstString = Console.ReadLine().Split(' ').ToArray();
        var secondString = Console.ReadLine().Split(' ').ToArray();


        int sumCount = 0;
        if (firstString[0]== secondString[0])
        {

       
            if (firstString.Length >= secondString.Length)
            {
            
                for (int i = 0; i < secondString.Length; i++)
                {
                    if (firstString[i]==secondString[i])
                    {
                        sumCount++;
                    }
                    else
                    {
                        break;

                    }
                }
            
            }
            else if (firstString.Length < secondString.Length)
            {
                for (int i = 0; i < firstString.Length; i++)
                {
                    if (firstString[i] == secondString[i])
                    {
                        sumCount++;
                    }
                    else
                    {
                        break;

                    }
                }
            }
        }
        else
        {
            Array.Reverse(firstString);
            Array.Reverse(secondString);
            if (firstString.Length >= secondString.Length)
            {

                for (int i = 0; i < secondString.Length; i++)
                {
                    if (firstString[i] == secondString[i])
                    {
                        sumCount++;
                    }
                    else
                    {
                        break;

                    }
                }

            }
            else if (firstString.Length < secondString.Length)
            {
                for (int i = 0; i < firstString.Length; i++)
                {
                    if (firstString[i] == secondString[i])
                    {
                        sumCount++;
                    }
                    else
                    {
                        break;

                    }
                }
            }
        }
        Console.WriteLine(sumCount);
    }
}

