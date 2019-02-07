using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    abstract class Vvehicle
    {
        protected string make;
        protected string model;
        protected string yearModel;
        protected double price;

        public Vvehicle()
        {
            make = String.Empty;
            model = String.Empty;
            yearModel = String.Empty;
            price = 0;
        }

        public Vvehicle(string make, string model, string yearModel, double price)
        {
            this.make = make;
            this.model = model;
            this.yearModel = yearModel;
            this.price = price;
        }

        public virtual void PrintData()
        {
            Console.WriteLine($"Tyyppi: {this.make}\n" +
                $"Merkki: {this.model}\n" +
                $"Vuosimalli: {this.yearModel}\n" +
                $"Hinta: {this.price:c}");
        }

        public override string ToString()
        {
            return $"Tyyppi: {this.make}\nMerkki: {this.model}\nVuosimalli: {this.yearModel}\nHinta: {this.price:c}";
        }
    }
}
