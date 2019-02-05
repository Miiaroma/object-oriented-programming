using System;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjema tulostaa kulkuvälineiden tietoja");
            Console.WriteLine();

            Console.OutputEncoding = System.Text.Encoding.UTF8;
                       
            Vcar firstCar = new Vcar("Henkilöauto", "VM", "2018", 30000, 2000,"123", 4);
            Vcar secondCar = new Vcar("Henkilöauto", "BMV", "2016", 35000, 2000, "Sport", 2);
            Truck truck = new Truck("Kuorma-auto","Scania", "2008", 200000, 4000, "XYZ", 2, 25000, 25);
            
            Console.WriteLine(firstCar.ToString());
            Console.WriteLine(secondCar.ToString());

            Console.WriteLine();

            if (firstCar.Equals(secondCar))
            {
                Console.WriteLine("\nAutot ovat samoja.\n");
            }
            else
            {
                Console.WriteLine("\nAutot eivät ole samoja.");
            }
            Console.WriteLine();

            truck.PrintData();

            Console.WriteLine("Press enter to continue..");
            Console.ReadLine();
        }
    }
}
