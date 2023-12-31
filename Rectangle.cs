﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment_17
{
    // Derived class representing a rectangle
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height) : base("Rectangle")
        {
            Width = width;
            Height = height;
        }

        public override double Area => Width * Height;

        public override double Perimeter => 2 * (Width + Height);
    }

}
