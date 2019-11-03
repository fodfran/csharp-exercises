using System;
using System.Collections.Generic;

namespace min_max_difference
{
    class Program
    {
        static void Main(string[] args)
        {
            

            List<int> the_array = new List<int>() { 15, 22, 84, 14, 88, 23 };
            Console.WriteLine(findMinMaxDifference(the_array));

        }

        static int findMinMaxDifference(List<int> array)
        {
            int min = array[0];
            int max = array[0];
            foreach (int num in array)
            {
                if (num < min)
                {
                    min = num;
                }
                if (num > max)
                {
                    max = num;
                }
            }
            
            return max - min;
        }
    }
}
