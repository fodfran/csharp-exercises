using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenNumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(); //{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string newNumberInput;
            int newNumber;

            Console.WriteLine("Enter a number (or ENTER to finish):");
            do
            {
                newNumberInput = Console.ReadLine();
                if (newNumberInput != "")
                {
                    newNumber = int.Parse(newNumberInput);
                    numbers.Add(newNumber);
                }
            }
            while (newNumberInput != "");


            Console.WriteLine(EvenSum.GetEvenSum(numbers));
            Console.ReadLine();

        }
    }
}
