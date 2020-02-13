using System;
using System.Linq;

namespace _3.Fold_and_Sum
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = numbers.Length / 4;

            int[] middleElements = new int[2 * k];

            for (int i = 0; i < middleElements.Length; i++)
            {
                middleElements[i] = numbers[k + i];
            }

            int[] firstKElements = new int[k];
            int[] lastKElements = new int[k];

            for (int i = 0; i < firstKElements.Length; i++)
            {
                firstKElements[i] = numbers[firstKElements.Length - i - 1];
                lastKElements[i] = numbers[numbers.Length - i - 1];
            }

            int[] sumOFElements = firstKElements.Union(lastKElements).ToArray();

            int[] sumOfArrays = new int[2 * k];

            for (int i = 0; i < sumOfArrays.Length; i++)
            {
                sumOfArrays[i] += sumOFElements[i] + middleElements[i];
            }

            Console.WriteLine(string.Join(" ", sumOfArrays));


        }
    }
}
