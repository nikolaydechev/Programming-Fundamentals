using System;
using System.Linq;

namespace _2.Rotate_and_Sum
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            int[] sumOfRotations = new int[numbers.Length];

            for (int i = 0; i < k; i++)
            {
                var lastElement = numbers[numbers.Length - 1];
                //Array.Copy(numbers, 0, numbers, 1, numbers.Length - 1 ); // Това замества for-цикъла, под този текст.//
                for (int j = numbers.Length - 1; j > 0; j--)
                {
                    numbers[j] = numbers[j - 1];
                }
                numbers[0] = lastElement;

                for (int a = 0; a < numbers.Length; a++)
                {
                    sumOfRotations[a] += numbers[a];
                }

            }
            Console.WriteLine(string.Join(" ", sumOfRotations));

        }
    }
}
