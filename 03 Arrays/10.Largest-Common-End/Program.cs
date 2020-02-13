using System;

namespace Largest_Common_End
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();

            int shorterArray = Math.Min(firstArray.Length, secondArray.Length);

            int leftCounter = CommonEnd(firstArray, secondArray, shorterArray);

            Array.Reverse(firstArray);
            Array.Reverse(secondArray);

            int rightCounter = CommonEnd(firstArray, secondArray, shorterArray);

            Console.WriteLine(Math.Max(leftCounter, rightCounter));

        }

        public static int CommonEnd(string[] firstArray, string[] secondArray, int shorterArray)
        {
            var count = 0;

            for (int i = 0; i < shorterArray; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            return count;
        }
    }
}

