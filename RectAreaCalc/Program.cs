using System;

namespace AreaRectCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Width?");
            string widthInput = Console.ReadLine();
            double width = double.Parse(widthInput);
            Console.WriteLine("Length?");
            string lengthInput = Console.ReadLine();
            double length = double.Parse(lengthInput);
            double area = width * length;
            Console.WriteLine("The area of your rectangle is: "
                + area.ToString());
            Console.ReadLine();
        }
    }
}
