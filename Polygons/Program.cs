using System;

namespace Polygons
{
    class Program
    {
        static void Main(string[] args)
        {
            Square sq = new Square("red", 4);
            Circle ci = new Circle("blue", 2.5);

            Console.WriteLine(sq.GetSides());
            Console.WriteLine(ci.GetColor());

            Console.WriteLine(sq.GetArea());
            Console.WriteLine(ci.GetCircumference());
        }
    }
}
