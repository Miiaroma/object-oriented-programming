using System;
using System.Collections.Generic;

namespace Interface_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rajapinta");

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Product firstProd = new Product("Talvitakki", 129.90, 10);
            Product secondProd = new Product("Housut", 39.90, 15);
            Product thirdProd = new Product("Kengät", 59.90, 10);

            /*Console.WriteLine(firstProd.ToString());
            Console.WriteLine(secondProd.ToString());
            
            Console.WriteLine(firstProd.CalculateTotal());
            Console.WriteLine(secondProd.CalculateTotal());*/

            List<Product> pList = new List<Product>();
            pList.Add(firstProd);
            pList.Add(secondProd);
            pList.Add(thirdProd);                     

            foreach (Product p in pList)
            {
                if (p.GetProduct("Talvitakki") != null)
                {
                    Console.WriteLine(p.ToString());
                }
                else
                {
                    Console.WriteLine("Tietoa tuotteesta ei ole saatavilla");
                }
            }

            foreach (Product p in pList)
            {                
                Console.WriteLine($"{p.CalculateTotal():c}");               
            }
              
            Customer firstCust = new Customer("Matti", 129.90);
            Customer secondCust = new Customer("Maija", 260.00);
            Customer thirdCust = new Customer("Aku", 39.90);

            List<Customer> cList = new List<Customer>();
            cList.Add(firstCust);
            cList.Add(secondCust);
            cList.Add(thirdCust);

            foreach (Customer c in cList)
            {
                if (c.GetCustomer("Matti") != null)
                {
                    Console.WriteLine(c.ToString());
                }
                else
                {
                    Console.WriteLine("Tietoa asiakkaasta ei ole saatavilla");
                }
            }

            foreach (Customer c in cList)
            {                
                Console.WriteLine($"{c.GetBonus():c}");
            }

            Store store = new Store("Vaateliike Mode", 100000);

            foreach (Product p in pList)
            {                
                store.AddProduct(p);
            }

            foreach (Customer c in cList)
            {
                store.AddCustomer(c);
            }

            store.PrintCustomers();
            store.PrintProducts();

            Console.WriteLine("Press enter to continue..");
            Console.ReadLine();
        }
    }
}
