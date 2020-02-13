using System;
using System.Linq;

namespace _6.MaxSequence_of_EqualElements
{
    class MaxSequence_of_EqualElements
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var maxCount = 0;
            var count = 0;
            var element = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        element = numbers[i];
                    }
                }
                else
                {
                    count = 0;
                }

            }

            for (int i = 0; i < maxCount + 1; i++)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
