using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Truck : Vcar
    {
        protected int loadWeight;
        protected int consumptionPerKg;

        public Truck()
        {
            loadWeight = 0;
            consumptionPerKg = 0;
        }

        public Truck(string make, string model, string yearModel, double price, int engineSize, string brand, int nbrOfDoors, int loadWeight, int consumptionPerKg): 
        base(make, model, yearModel, price, engineSize, brand, nbrOfDoors)
            {
            this.loadWeight = loadWeight;
            this.consumptionPerKg = consumptionPerKg;
        }

        public override void PrintData()
        {
            base.PrintData();
            Console.WriteLine($"\nLastin paino on: {loadWeight} kg, kulutus per kg: {consumptionPerKg} l" +
                $" ja polttoaineen kulutus: {this.CalculateConsumption()} l.\n");
        }

        public int CalculateConsumption()
        {
            return this.loadWeight * this.consumptionPerKg;
        }
    }
}
