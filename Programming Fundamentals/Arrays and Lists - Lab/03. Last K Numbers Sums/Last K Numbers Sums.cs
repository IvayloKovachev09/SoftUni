using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        long[] arr = new long[n];
        arr[0] = 1;
        for (int i = 1; i < n; i++)
        {
            long sum = 0;
            for (long p = i-k; p <= i-1; p++)
            {
                if (p>=0)
                {
                    sum += arr[p];
                }
                arr[i] = sum;
            }
        }
        for (long i = 0; i < n; i++)
        {
            Console.Write("{0} ",arr[i]);
        }
       
    }
}

