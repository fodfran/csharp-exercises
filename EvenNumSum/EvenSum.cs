using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenNumSum
{
    public class EvenSum
    {
        public static int GetEvenSum(List<int> numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }

            }
            return sum;
        }
    }
}
