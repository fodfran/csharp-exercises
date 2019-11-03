using System;

namespace AreaCircleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string radiusInput;
            double radius;

            do
            {
                
                Console.WriteLine("Enter a radius: ");
                radiusInput = Console.ReadLine();
                radius = double.Parse(radiusInput);
                if (radius < 0)
                {
                    Console.WriteLine("Invalid radius");
                }
                
            } while (radius < 0);


                double area = Math.Pow(radius, 2) * Math.PI;
            Console.WriteLine("The area of a circle with " +
                "a radius of " + radius.ToString() + " is: "
                + area.ToString());
            Console.ReadLine();
        }
    }
}
