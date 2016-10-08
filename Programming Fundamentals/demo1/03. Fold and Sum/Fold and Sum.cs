using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fold_and_Sum
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> stringSum = new List<int>(numbers);
            //List<int> newList = new List<int>();
            
            var count = stringSum.Count/4;
            var newString = 0;
            for (int i =1 ; i <= count; i++)
            {

                stringSum.Remove(i);
               
                
            }
            for (int g = stringSum.Count +1/4* stringSum.Count; g >  stringSum.Count-1; g--)
            {
                stringSum.Remove(g);
            }






        }
    }
}
