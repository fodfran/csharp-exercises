using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles have you driven?");
            string milesInput = Console.ReadLine();
            double miles = double.Parse(milesInput);
            Console.WriteLine("How many gallons of gas have you consumed?");
            string gasInput = Console.ReadLine();
            double gas = double.Parse(gasInput);
            double milesPerGallon = miles / gas;
            Console.WriteLine("Gas consumption rate: "
                + milesPerGallon.ToString() + " mpg");
            Console.ReadLine();
        }
    }
}
