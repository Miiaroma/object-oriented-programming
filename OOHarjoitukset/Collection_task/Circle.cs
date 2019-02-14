using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_task
{
    class Circle : Shape
    {
        protected double radius;

        public Circle()
        {
            radius = 0;
        }

        public Circle(string type, string color, double radius)
            :base (type, color)
        {
            this.radius = radius;             
        }

        public override double GetArea()
        {
            double pi = Math.PI;
            return pi*radius * radius;
        }

        public string GetColour()
        {
            return color;
        }

        public override string GetInfo()
        {
            color = GetColour();
            return $"{base.ToString()}\tRadius: {radius:F2}\tArea: {GetArea():F2}.";
        }
    }     
}



