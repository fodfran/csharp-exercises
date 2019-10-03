using System;
namespace Polygons
{
    public class Shape : AbstractEntity
    {

        public string Color { get; set; }
        public int Sides { get; set; }

        public Shape(string color, int sides)
        {
            Color = color;
            Sides = sides;
        }

        public string GetColor()
        {
            return Color;
        }

        public int GetSides()
        {
            return Sides;
        }
    }
}
