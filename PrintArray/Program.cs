using System;

namespace PrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 2, 3, 5, 8 };

            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
            
        }
    }
}
