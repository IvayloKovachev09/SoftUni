using System;

public class Program
{
    public static void Main()
    {
        using System;

public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());


            Console.WriteLine(FibonachiNumber(number));

        }
        public static int FibonachiNumber(int n)
        {
            int a = 1;
            int b = 2;
            for (int i = 1; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;


        }
    }

}
}

