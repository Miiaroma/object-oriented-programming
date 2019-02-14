using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_task
{
    class Tritangle : Shape
    {
        public double length;
        public double width;

        public Tritangle()
        {
            length = 0;
            width = 0;
        }

        public Tritangle(string type, string color, double length, double width)
            : base(type, color)
        {
            this.length = length;
            this.width = width;
        }

        public override double GetArea()
        {
            return length * width / 2;
        }

        public override string GetInfo()
        {
            return $"{base.ToString()}\tLenght: {length:F2}\tWith: {width:F2}\tArea: {GetArea():F2}.";
        }
    }
}
