using System;

namespace dz02._04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int[] numbers = { 7, 14, 21, 3, 5, 8, 10, 28, 35, 42 };

            Func<int[], int> countMultiplesOfSeven = arr => Array.FindAll(arr, num => num % 7 == 0).Length;

            Console.WriteLine($"Кількість чисел у масиві, кратних семи: {countMultiplesOfSeven(numbers)}");
        }
    }
}
