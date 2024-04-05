using System;

namespace LambdaExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int[] numbers = { 1, -2, 3, -4, 5, -6, 7, -8, 9, -10 };

            Func<int[], int> countPositiveNumbers = arr => Array.FindAll(arr, num => num > 0).Length;

            Console.WriteLine($"Кількість позитивних чисел у масиві: {countPositiveNumbers(numbers)}");
        }
    }
}
