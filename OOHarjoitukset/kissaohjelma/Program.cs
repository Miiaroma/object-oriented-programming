using System;

namespace kissaohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä on kissaohjelma");

            Cat myFirstCat = new Cat("Pilli", 1);
            myFirstCat.IncreaseWeight(1);
            myFirstCat.PrintWeight();
            // myFirstCat.weight = 5;
            //Console.WriteLine($"Kissan paino on muutettu {myFirstCat.weight}");
            Console.Write("-------------------------------------------------------\n");

            Cat cat = new Cat("Pulla", 3);
            cat.PrintWeight();
            Console.Write("Press any key to continue...\n");
            Console.ReadKey();
        }
    }
}
