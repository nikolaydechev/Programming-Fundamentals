using System;
using System.Linq;

namespace _8.MostFrequentNumbers
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var number = 0;
            var maxCount = 0;

            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                var count = 0;

                for (int j = 0; j <= numbers.Length - 1; j++)
                {
                    if (numbers[j] == numbers[i])
                    {
                        count++;
                        if (count > maxCount)
                        {
                            maxCount = count;
                            number = numbers[j];
                        }
                    }
                }
            }
            Console.WriteLine(number);
        }
    }
}
