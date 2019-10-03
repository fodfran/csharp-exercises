using System;
namespace Polygons
{
    public class Square : Shape
    {
        public double SideLength { get; set; }

        public Square(string color, double sideLength, int sides = 4) : base(color, sides)
        {
            SideLength = sideLength;
        }

        public double GetArea()
        {
            return SideLength * SideLength;
        }

        public double GetPerimeter()
        {
            return SideLength * Sides;
        }
    }
}
