using System;

namespace AreaCircleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius: ");
            string radiusInput = Console.ReadLine();
            double radius = double.Parse(radiusInput);

            while (radius < 0)
            {
                Console.WriteLine("Invalid radius");
                Console.WriteLine("Enter a radius: ");
                radiusInput = Console.ReadLine();
                radius = double.Parse(radiusInput);
            }
            
            double area = Math.Pow(radius, 2) * Math.PI;
            Console.WriteLine("The area of a circle with " +
                "a radius of " + radius.ToString() + " is: "
                + area.ToString());
            Console.ReadLine();
        }
    }
}
