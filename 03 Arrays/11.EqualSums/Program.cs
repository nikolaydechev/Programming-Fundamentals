using System;
using System.Linq;

namespace _11.EqualSums
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool indexFound = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                var leftSum = 0;
                var rightSum = 0;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    rightSum += numbers[j];
                }
                for (int a = 0; a < i; a++)
                {
                    leftSum += numbers[a];
                }
                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    indexFound = true;
                    break;
                }
            }
            if (!indexFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
