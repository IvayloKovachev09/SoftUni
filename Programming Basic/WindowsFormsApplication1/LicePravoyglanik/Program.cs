using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicePravoyglanik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лице на правоъгалник:");
            Console.Write("Страна а=");
            var a = decimal.Parse(Console.ReadLine());
            Console.Write("Страна b=");
            var b = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Лицето на правоъгалника е:");
            var c = (a * b);
            Console.WriteLine(c);
            if(c/b==a)
            {
                Console.WriteLine("Решението е вярно");
            }
            else
            {
                Console.WriteLine("Решението е грешно");
            }


        }
    }
}
