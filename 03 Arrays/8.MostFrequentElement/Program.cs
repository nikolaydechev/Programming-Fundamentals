using System;
using System.Linq;

namespace _8.MostFrequentElement
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int resultNumber = 0;
            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int tempCounter = 0;

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        tempCounter++;
                    }
                }
                if (tempCounter > counter)
                {
                    counter = tempCounter;
                    resultNumber = numbers[i];
                }

                //foreach (var number in numbers)
                //{
                //    if (numbers[i] == number)
                //    {
                //        tempCounter++;
                //    }

                //    if (tempCounter > counter)
                //    {
                //        counter = tempCounter;
                //        resultNumber = numbers[i];
                //    }
                //}
            }
            Console.WriteLine(resultNumber);
        }

        public static void OtherSolution()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] distinctNumbers = numbers.Distinct().OrderBy(x => x).ToArray();
            int[] repeats = new int[distinctNumbers.Length];

            for (int i = 0; i < distinctNumbers.Length; i++)
            {
                repeats[i] = numbers.Count(number => number == distinctNumbers[i]);
            }
            Console.WriteLine(distinctNumbers[repeats.ToList().IndexOf(repeats.Max())]);

        }
    }
}
