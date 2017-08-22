using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Type_Veriables
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght, width, V = 0;
            Console.Write("Length: ");
            lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());
            Console.Write("Heigth: ");
            V = double.Parse(Console.ReadLine());
            V = (dul * sh * V) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", V);

        }
    }
}
