using System;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Завдання 1
            Predicate<int> isEven = delegate (int number) { return number % 2 == 0; };
            Console.WriteLine($"Число 6 парне: {isEven(6)}");
            Console.WriteLine($"Число 7 парне: {isEven(7)}");

            //Завдання 2
            Func<int, int> square = delegate (int x) { return x * x; };
            Console.WriteLine($"Квадрат числа 5: {square(5)}");

            //Завдання 3
            Func<int, int> cube = x => x * x * x;
            Console.WriteLine($"Куб числа 3: {cube(3)}");

            //Завдання 4
            Func<DateTime, bool> isProgrammersDay = date => date.DayOfYear == 256;
            Console.WriteLine($"2024-09-12 - день програміста: {isProgrammersDay(new DateTime(2024, 9, 12))}");

            //Завдання 5
            Func<int[], int> findMax = array => {
                int max = int.MinValue;
                foreach (var num in array)
                {
                    if (num > max)
                        max = num;
                }
                return max;
            };
            int[] numbers = { 3, 8, 2, 10, 5 };
            Console.WriteLine($"Максимум в масиві: {findMax(numbers)}");

            //Завдання 6
            Func<int[], int> findMin = array => {
                int min = int.MaxValue;
                foreach (var num in array)
                {
                    if (num < min)
                        min = num;
                }
                return min;
            };
            Console.WriteLine($"Мінімум в масиві: {findMin(numbers)}");

            //Завдання 7
            Func<int[], int[]> findOddNumbers = array => Array.FindAll(array, num => num % 2 != 0);
            int[] numbers2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine($"Непарні числа в масиві: {string.Join(", ", findOddNumbers(numbers2))}");
        }
    }
}
