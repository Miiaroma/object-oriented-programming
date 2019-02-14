using System;
using System.Collections.Generic;

namespace Collection_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program prints information on shapes.\n");


            Circle circle = new Circle("Circle", "Red", 5);
            Tritangle tritangle = new Tritangle("Triangle", "Blue", 4, 3);
            Rectangle rectangle = new Rectangle("Rectangle", "Green", 6, 9);


            List<Shape> shapes = new List<Shape>();
            shapes.Add(circle);
            shapes.Add(tritangle);
            shapes.Add(rectangle);


            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.GetInfo());
            }

            foreach (Shape type in shapes)

            if (type is Circle)
                {
                    Console.WriteLine($"{type.GetInfo()}");
                }

            Console.WriteLine("Press enter to continue..");
            Console.ReadLine();
        }
    }
}
