using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Numbers
{
    public class Numbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            double sumOfNumbers = 0.0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sumOfNumbers += numbers[i];
            }

            double averageNumber = sumOfNumbers / numbers.Length;
            var result = new List<double>();

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] > averageNumber)
                {
                    result.Add(numbers[i]);
                }
            }
            if (result.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }

            var sortedNumbers = result
                .OrderByDescending(x => x)
                .Take(5);
            

            Console.Write(string.Join(" ", sortedNumbers));

            Console.WriteLine();
        }
    }
}
