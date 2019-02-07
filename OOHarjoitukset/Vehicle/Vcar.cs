using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Vcar : Vvehicle
    {
        protected int engineSize;
        protected string brand;
        protected int nbrOfDoors;


        public Vcar()
        {
            engineSize = 0;
            brand = String.Empty;
            nbrOfDoors = 0;
        }

        public Vcar(string make, string model, string yearModel, double price, int engineSize, string brand, int nbrOfDoors) : 
            base(make, model, yearModel, price)

        {
            this.engineSize = engineSize;
            this.brand = brand;
            this.nbrOfDoors = nbrOfDoors;
        }

        public override void PrintData()

        {
            base.PrintData();
            Console.WriteLine($"Koneenkoko: {this.engineSize}\nMalli: {this.brand}\nOvienlkm: {this.nbrOfDoors}");
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nKoneenkoko: {this.engineSize}\nMalli: {this.brand}\nOvienlkm: {this.nbrOfDoors}\n";
        }

        public override bool Equals(Object obj)
        {
            Vcar carObj = obj as Vcar;

            if (carObj == null)
                return false;
            else
            {
                return this.model.Equals(carObj.model) && this.brand.Equals(carObj.brand) &&
                this.nbrOfDoors.Equals(carObj.nbrOfDoors) && this.engineSize.Equals(carObj.engineSize)
                && this.price.Equals(carObj.price) && this.make.Equals(carObj.make) && this.yearModel.Equals(carObj.yearModel);
            }
        }
    }
}

