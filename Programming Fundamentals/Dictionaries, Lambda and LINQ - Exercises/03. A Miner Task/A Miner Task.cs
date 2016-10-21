using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        Dictionary<string, long> product = new Dictionary<string, long>();
        string nameOfProduct = Console.ReadLine();
        while (!nameOfProduct.Equals("stop"))
        {
            long quantity = long.Parse(Console.ReadLine());        
           
            if (! product.ContainsKey(nameOfProduct))
            {
                product.Add(nameOfProduct,0);
            }
            product[nameOfProduct] += quantity;
            
            nameOfProduct = Console.ReadLine();
            
        }
        foreach (var kyr in product)
        {
            Console.WriteLine("{0} -> {1}", kyr.Key, kyr.Value);
        }
    }
}

