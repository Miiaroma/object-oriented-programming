using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_task
{
    class Store : ICustomers, IProducts
    {
        private string _name;
        private double _turnover;
        List<Product> pList;
        List<Customer> cList;

        public Store()
        {
            _name = String.Empty;
            _turnover = 0;
            pList = new List<Product>();
            cList = new List<Customer>();
        }

        public Store(string name, double turnover)
        {
            this._name = name;
            this._turnover = turnover;
            pList = new List<Product>();
            cList = new List<Customer>();
        }

        public void AddProduct(Product product)
        {
            pList.Add(product);
        }

        public void AddCustomer(Customer customer)
        {
            cList.Add(customer);
        }

        public override string ToString()
        {
            return $"\nNimi: {_name}\nLiikevaihto: {_turnover:c}\nAsiakkaiden lukumäärä: {cList.Count}\nTuotenimikkeiden lukumäärä: {pList.Count}";
        }

        public void PrintProducts()
        {
            Console.WriteLine($"Tuotetiedot\n ");

            foreach (Product p in pList)
            {
                Console.WriteLine(p);
                Console.WriteLine($"Tuotteiden yhteishinta: {p.CalculateTotal():c}\n");
            }
        }

        public void PrintCustomers()
        {
            Console.WriteLine($"Asiakastiedot\n ");

            foreach (Customer c in cList)
            {
                Console.WriteLine($"{c.ToString()}");
            }
        }
    }
}
