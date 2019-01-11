using System;
using System.Collections.Generic;
using System.Text;

namespace Car_program
{
    class Car
    {
        public string brand;
        public int speed;

        public Car()
        {

        }

        public Car(string brand, int speed)
        {
            this.brand = brand;
            this.speed = speed;
        }

        public void AskData()
        {
            Console.WriteLine("Syötä auton merkki: ");
            brand = Console.ReadLine();
            Console.WriteLine("Syötä nopeus: ");
            string speedValue = Console.ReadLine();
            bool isNumber = int.TryParse(speedValue, out int speed);

            //if (!int.TryParse(speedValue, out int speed))
            //{
            //    speed = 0;
            //    Console.WriteLine("Tarkasta syöte!");
            //}

            if (isNumber)
            {
                this.speed = speed;
            }
            else
            {
                Console.WriteLine("Tarkasta syöte!");
                this.speed = 0;
            }
        }

        public void ShowCarInfo()
        {
            Console.WriteLine($"Auton {brand} nopeus on {speed}.\n");
        }

        public void Accelerate(string increaseSpeedValue)
        {
            //int increaseSpeed = int.Parse(increaseSpeedValue);
            //int increaseSpeed = 0;

            if (!int.TryParse(increaseSpeedValue, out int increaseSpeed))
            {
                increaseSpeed = 0;
            }

            if (increaseSpeed > 0)
            {
                this.speed += increaseSpeed;
                Console.WriteLine($"Nopeutta lisättiin {increaseSpeed}, uusi nopeus on {this.speed} km/h\n");
            }
            else if (increaseSpeed == 0)
            {
                Console.WriteLine("Ei muutosta");
            }
            else
            {
                Console.WriteLine("Negatiivista muutosta ei sallita");
            }
        }

        public void Brake()
        {
            //speed = Convert.ToInt32(speed * 0.9);
            speed = 90 * speed / 100;
            Console.WriteLine($"Nopeutta vähennettiin 10%, uusi nopeus on {speed} km/h\n");
            Console.WriteLine("--------------------------------------------------------\n");
        }
    }
}
