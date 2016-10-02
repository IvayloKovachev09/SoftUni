using System;
using System.Globalization;

class DaysAfterBirth
{
    static void Main(string[] args)
    {
        var date = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
        date = date.AddDays(999);
        Console.WriteLine(date.ToString("dd-MM-yyyy"));

    }
}

     
    
