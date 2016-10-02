using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double underTwoTousen = 0;
        double mejduDvestaCheristotin = 0;
        double mejduChetiristotinShestotin = 0;
        double mejduShestotinOsemstotin = 0;
        double nadOsemstotin = 0;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 200)
            {
                underTwoTousen += 1;
            }
            else if (number >= 200 && number <= 399)
            {
                mejduDvestaCheristotin += 1;
            }
            else if (number >= 400 && number <= 599)
            {
                mejduChetiristotinShestotin += 1;
            }
            else if (number >= 600 && number <= 799)
            {
                mejduShestotinOsemstotin += 1;
            }
            else if (number >= 800)
            {
                nadOsemstotin += 1;
            }

        }
        Console.WriteLine("{0:f2}%", underTwoTousen / n * 100);
        Console.WriteLine("{0:f2}%", mejduDvestaCheristotin / n * 100);
        Console.WriteLine("{0:f2}%", mejduChetiristotinShestotin / n * 100);
        Console.WriteLine("{0:f2}%", mejduShestotinOsemstotin / n * 100);
        Console.WriteLine("{0:f2}%", nadOsemstotin / n * 100);
    }
}

