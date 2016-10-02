using System;

    class Program
    {
        static void Main()
        {
        int n = int.Parse(Console.ReadLine());
        
        if (n%2==0)
        {
            for (int i = 0; i < n/2; i++)
            {
                var leftRight = new string('-', (n - 1) / 2 - i);
                var mid = new string('-', i*2);
                Console.WriteLine("{0}*{1}*{0}",leftRight,mid);
            }
            for (int d = 0; d <(n/2)-1; d++)
            {
                var leftRight = new string('-',  1 + d);
                var mid = new string('-', n-4 - 2*d);
                Console.WriteLine("{0}*{1}*{0}",leftRight,mid);
            }
        }
        else
        {
            for (int p = 0; p < (n/2)+1; p++)
            {
                var leftRight = new string('-', (n - 1) / 2 - p);
                
                if (p==0)
                {
                    Console.WriteLine("{0}*{0}", leftRight);
                }
                else
                {
                    var mid = new string('-', (p * 2) - 1);
                    Console.WriteLine("{0}*{1}*{0}", leftRight,mid);
                }
            }

           
                for (int p1 = 0; p1 < (n / 2)-1; p1++)
                {
                
                
                    var leftRight = new string('-', p1 + 1);
                    var mid = new string('-', n - 4 - 2 * p1);
                    Console.WriteLine("{0}*{1}*{0}", leftRight, mid);
                }
            if (n!=1)
            {
                var tire = new string('-', n / 2);
                Console.WriteLine("{0}*{0}", tire);
            }
                
                   
                

                }
           
 
        }
    
        }
    

