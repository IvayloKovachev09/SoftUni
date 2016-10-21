using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.AndreyAndBilliard
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, decimal> productsPrice = new Dictionary<string, decimal>();
            int productCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < productCount; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                string productName = input[0];
                decimal productPrice = decimal.Parse(input[1]);

                if (!productsPrice.ContainsKey(productName))
                {
                    productsPrice.Add(productName, productPrice);
                }
                productsPrice[productName] = productPrice;
            }
            string inputLine = Console.ReadLine();
            List<Customer> customers = new List<Customer>();
            while (!inputLine.Equals("end of clients"))
            {
                string[] customerInfo = inputLine.Split(',','-');
                string customerName = customerInfo[0];
                string customerProduct = customerInfo[1];
                int quantity = int.Parse(customerInfo[2]);

                if (!productsPrice.ContainsKey(customerProduct))
                {
                    inputLine = Console.ReadLine();
                    continue;
                }
                if (customers.Any(x => x.Name == customerName))
                {
                    Customer customer = customers.First(v => v.Name == customerName);
                    if (!customer.OrderQuantity.ContainsKey(customerProduct))
                    {
                        customer.OrderQuantity.Add(customerProduct, quantity);
                    }
                    else
                    {
                        customer.OrderQuantity[customerProduct] += quantity;
                    }
                    customer.Bill += quantity * productsPrice[customerProduct];
                }
                else
                {
                    Customer customer = new Customer();
                    customer.Name = customerName;
                    customer.OrderQuantity = new Dictionary<string, int>();
                    customer.OrderQuantity.Add(customerProduct, quantity);
                    customer.Bill += quantity * productsPrice[customerProduct];
                    customers.Add(customer);

                }
                inputLine = Console.ReadLine();
            }
            foreach (Customer customer in customers.OrderBy(a => a.Name))
            {
                Console.WriteLine(customer.Name);
                foreach (KeyValuePair<string, int> customerOrders in customer.OrderQuantity)
                {
                    Console.WriteLine("-- {0} - {1}", customerOrders.Key, customerOrders.Value);
                }
                Console.WriteLine("Bill: {0:f2}", customer.Bill);
            }
            decimal totalBill = customers.Sum(a => a.Bill);
            Console.WriteLine("Total bill: {0:f2}", totalBill);


        }
        public class Customer
        {
            public string Name { get; set; }
            public Dictionary<string, int> OrderQuantity { get; set; }
            public decimal Bill { get; set; }
        }
    }

}
