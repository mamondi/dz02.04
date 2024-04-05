using System;
using System.Collections.Generic;

namespace dz02._04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { -2, 3, -4, 3, -6, -2, 7, -8, 9, -10 };

            Func<int[], IEnumerable<int>> uniqueNegativeNumbers = arr =>
            {
                HashSet<int> uniqueNegatives = new HashSet<int>();
                foreach (var num in arr)
                {
                    if (num < 0)
                    {
                        uniqueNegatives.Add(num);
                    }
                }
                return uniqueNegatives;
            };

            Console.WriteLine("Унікальні негативні числа у масиві:");
            foreach (var num in uniqueNegativeNumbers(numbers))
            {
                Console.WriteLine(num);
            }
        }
    }
}
