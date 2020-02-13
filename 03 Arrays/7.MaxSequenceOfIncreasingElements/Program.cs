using System;
using System.Linq;

namespace _7.MaxSequenceOfIncreasingElements
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var maxCount = 0;
            var count = 0;
            var start = 0;
            var maxStart = 0;

            int[] elements = new int[numbers.Length];

            for (int i = 1; i < numbers.Length ; i++)
            {
                if (numbers[i] - numbers[i - 1] >= 1)
                {
                    count++;
                    start = i - count;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxStart = start;
                    }
                }
                else
                {
                    count = 0;
                }
            }

            for (int i = maxStart; i <= (maxStart + maxCount); i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
