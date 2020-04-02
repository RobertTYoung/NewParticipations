using System;
using System.Collections.Generic;
using System.Text;

namespace _P__Classes___Rectangle_And_Circle
{
    class Circle
    {
        public double Radius{ get; set; }

        public Circle()
        {
            Radius = 0;
        }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return (Math.PI) * (Radius * Radius);
        }
        public double CalculatePerimeter()
        {
            return (2*(Math.PI)) * Radius;
        }
    }
}
