using System;

namespace Car_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Autoluokka\n");
            Car firstCar = new Car();
            firstCar.AskData();
            firstCar.ShowCarInfo();

            Console.WriteLine("Anna kerroin, jolla auton nopeutta lisätään");
            firstCar.Accelerate(Console.ReadLine());
            firstCar.Brake();

            Car secondCar = new Car();
            secondCar.AskData();
            secondCar.ShowCarInfo();
            Console.WriteLine("Anna kerroin, jolla auton nopeutta lisätään");
            secondCar.Accelerate(Console.ReadLine());
            secondCar.Brake();                                     

            Console.Write("Press any key to continue...\n");
            Console.ReadKey();
        }
    }
}
