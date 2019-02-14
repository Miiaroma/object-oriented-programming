using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_task
{
    abstract class Shape
    {
        public string type;
        public string color;

        public Shape()
        {
            type = String.Empty;
            color = String.Empty;
        }

        public Shape(string type, string color)
        {
            this.type = type;
            this.color = color;
        }
               
        public string GetColor()
        {
            return color;
        }

        public abstract string GetInfo();

        public abstract double GetArea();

        public override string ToString()
        {
            return $"Shape: {type}\nColor: {color}";
        }
    }
}
