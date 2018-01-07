using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Andrey_and_Billiard
{
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> productsAndQuantity { get; set; }  // product i kolichestvo
        public decimal Bill { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> products = new Dictionary<string, decimal>(); // produkt s cena
            ReadProductsAndPrices(products);

            string line = Console.ReadLine();

            List<Customer> customers = new List<Customer>();

            while (line != "end of clients")
            {
                var input = line.Split(new char[] { ',', '-' });
                var name = input[0];
                var product = input[1];
                var quantity = int.Parse(input[2]);

                if (products.ContainsKey(product)) // v dictionary product i cena
                {
                    Customer customer = new Customer();
                    customer.Name = input[0];
                    customer.productsAndQuantity = new Dictionary<string, int>();
                    customer.productsAndQuantity.Add(product, quantity);
                    customer.Bill = products[product] * quantity;

                    bool isExist = false;

                    foreach (var item in customers)
                    {
                        if (item.Name == customer.Name)
                        {
                            isExist = true;
                            if (item.productsAndQuantity.ContainsKey(product))
                            {
                                item.productsAndQuantity[product] += quantity;
                            }
                            else
                            {
                                item.productsAndQuantity.Add(product, quantity);
                            }
                            item.Bill += products[product] * quantity;
                        }
                    }

                    if (!isExist)
                    {
                        customers.Add(customer);
                    }
                }

                line = Console.ReadLine();
            }
            
            foreach (var c in customers.OrderBy(c => c.Name))
            {
                Console.WriteLine(c.Name);

                foreach (var p in c.productsAndQuantity)
                {
                    Console.WriteLine($"-- {p.Key} - {p.Value}");                    
                }
                Console.WriteLine($"Bill: {c.Bill:F2}");
            }
            Console.WriteLine($"Total bill: {customers.Sum(p => p.Bill):f2}");
        }

        private static void ReadProductsAndPrices(Dictionary<string, decimal> products)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split('-');
                string product = line[0];
                decimal price = decimal.Parse(line[1]);

                if (!products.ContainsKey(product))
                {
                    products.Add(product, 0);
                }
                products[product] = price;
            }
        }
    }
}
