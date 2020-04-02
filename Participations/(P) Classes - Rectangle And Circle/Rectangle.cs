using System;
using System.Collections.Generic;
using System.Text;

namespace _P__Classes___Rectangle_And_Circle
{
    class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }
        

        public Rectangle()
        {
            Length = 0;
            Width = 0;                   
        }
        public Rectangle (double width, double length)
        {
            Length = length;
            Width = width;
        }
        public double CalculateAreaR()
        {
            return Length * Width;
        }
        public double CalculatePerimeterR()
        {
            return 2 * (Length * Width);
        }
    }
}
