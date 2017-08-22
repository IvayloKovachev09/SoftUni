using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
   public static void Main()
    {
        try
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(CulculatePositiveNumbers(a, b));
        }
        catch(FormatException) 
        {
            Console.WriteLine("Invalid number");
           
        }
        catch(ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Thank you for using");
        }
        
    }
    public static int CulculatePositiveNumbers(int a, int b)
    {
        if (a<0 || b<0)
        {
            throw new ArgumentException("Not numbers under null");
        }
        return a + b;
    }
 
}

