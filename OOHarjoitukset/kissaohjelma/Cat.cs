using System;
using System.Collections.Generic;
using System.Text;

namespace kissaohjelma
{
    class Cat
    {
        public string name;
        public int weight;

        public Cat()
        {
            this.weight = 1;
            //Console.WriteLine($"Kissan paino on alustettu arvoksi {this.weight}");
        }

        public Cat(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
            Console.WriteLine($"Luotu kissa {this.name}, jonka paino on {this.weight}");
        }

        public Cat(int weight)
        {
            this.weight = weight;
            //Console.WriteLine($"Kissan paino on {this.weight}");
        }

        public void IncreaseWeight(int value)
        {
            this.weight += value;

            Console.WriteLine($"Kissan {this.name} uusi paino on {this.weight}");           
        }

        public void PrintWeight()
        {
            Console.WriteLine($"Kissan {this.name} paino on {this.weight}");
        }
    }
}
