using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_task
{
    class Product : IProduct
    {
        private string _name;
        private double _price;
        private int _amount;

        public Product()
        {
            _name = String.Empty;
            _price = 0;
            _amount = 0;
        }

        public Product(string name, double price, int amount)
        {
            this._name = name;
            this._price = price;
            this._amount = amount;
        }

        public override string ToString()
        {
            return $"Tuote: {this._name}\nHinta: {this._price:c}\nMäärä: {this._amount}";
        }

        public Product GetProduct(string compareName)
        {
            if (this._name == compareName)
            {
                return this;
            }
            else
            {
                return null;
            }
        }

        public double CalculateTotal()
        {
            return _price*_amount;
        }
    }
}
