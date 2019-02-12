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
            return $"Kaupan nimi: {_name}\n, liikevaihto: {_turnover}\n, " +
                $"asiakkaiden lukumäärä: {cList.Count}\n, tuotteiden lukumäärä: {pList.Count}";
        }
       
        public void PrintProducts()
        {
            foreach (Product p in pList)
            {
                Console.WriteLine(p);
                Console.WriteLine(p.CalculateTotal());
            }
        }
        public void PrintCustomers()
        {
            foreach (Customer c in cList)
            {
                Console.WriteLine(c);
                Console.WriteLine(c.GetBonus());
            }
        }
    }
}
