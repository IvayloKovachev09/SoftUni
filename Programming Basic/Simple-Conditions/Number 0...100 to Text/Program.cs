using System;
 
class Program
{
    static void Main()
    {
        string[] word0to19 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        double[] num0to19 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9,10,11,12,13,14,15,16,17,18,19 };
        double[] num0to100 = {20,30,40,50,60,70,80,90,100};
        string[] word20to100 = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety", "one hundred" };
        int num = int.Parse(Console.ReadLine());
        
        if (num < 0 || num >100)
        {
            Console.WriteLine("invalid number");
        }
        else if (num >= 0 && num <=19)
        {
             Console.WriteLine( word0to19[num]);
        }
        else if (num >=20 && num <=100 && num%10 == 0)
        {
            var mass = Array.IndexOf(num0to100,num);
            Console.WriteLine(word20to100[mass]);
        }
        else if (num >20 && num<100 )
        {
            double firstnum = (num/10)*10;
            double secondnum = num % 10;
            int mass1 = Array.IndexOf(num0to100,firstnum);
            int mass2 = Array.IndexOf(num0to19, secondnum);
            Console.WriteLine(word20to100[mass1]+" "+word0to19[mass2]);
        }
    }
}