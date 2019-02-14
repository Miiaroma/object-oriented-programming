using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_task
{
    class Rectangle : Shape
    {
        protected double length;
        protected double width;

        public Rectangle()
        {
            length = 0;
            width = 0;
        }

        public Rectangle(string type, string color, double length, double width)
            : base(type, color)
        {
            this.length = length;
            this.width = width;
        }

        public override double GetArea()
        {
            return length * width;
        }

        public override string GetInfo()
        {
            return $"{base.ToString()}\tLenght: {length:F2}\twith: {width:F2}\tArea: {GetArea():F2}\n";
        }
    }
}
