using System;
namespace Polygons
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(string color, double radius, int sides = 0) : base(color, sides)
        {
            Radius = radius;

        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double GetCircumference()
        {
            return 2 * Math.PI * Radius;
        }

    }
}
