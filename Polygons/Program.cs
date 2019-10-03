using System;

namespace Polygons
{
    class Program
    {
        static void Main(string[] args)
        {
            Square sq = new Square("red", 4);
            Circle ci = new Circle("blue", 2.5);
            Square sq2 = new Square("green", 5);
            Shape sh = new Shape("orange", 4);

            Console.WriteLine(sq.GetSides());
            Console.WriteLine(ci.GetColor());

            Console.WriteLine(sq.GetArea());
            Console.WriteLine(ci.GetCircumference());

            Console.WriteLine(sq.GetShapeId());
            Console.WriteLine(ci.GetShapeId());
            Console.WriteLine(sq2.GetShapeId());
            Console.WriteLine(sh.GetShapeId());
        }
    }
}
