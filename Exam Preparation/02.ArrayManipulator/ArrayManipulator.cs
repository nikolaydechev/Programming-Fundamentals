using System;
using System.Linq;

namespace _02.ArrayManipulator
{
    public class ArrayManipulator
    {
        public static void Main()
        {
            var inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            while (true)
            {
                var command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }
                string[] commandArgs = command.Split();

                switch (commandArgs[0])
                {
                    case "exchange":
                        inputArray = Exchange(inputArray, int.Parse(commandArgs[1]));
                        break;
                    case "max":
                    case "min":
                        MaxAndMin(inputArray, commandArgs[0], commandArgs[1]);
                        break;
                    case "first":
                    case "last":
                        FirstAndLast(inputArray, commandArgs[0], int.Parse(commandArgs[1]), commandArgs[2]);
                        break;
                }
            }

            PrintArray(inputArray);
        }

        private static void FirstAndLast(int[] inputArray, string command, int count, string evenOrOdd)
        {
            if (count > inputArray.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            var filter = FilterEvenOrOdd(inputArray, evenOrOdd);

            int[] result;

            if (command == "first")
            {
                result = filter.Take(count).ToArray();
            }
            else
            {
                result = filter.Reverse().Take(count).Reverse().ToArray();
            }
            PrintArray(result);
        }

        private static void MaxAndMin(int[] inputArray, string command, string evenOrOdd)
        {
            var filter = FilterEvenOrOdd(inputArray, evenOrOdd);

            if (!filter.Any())
            {
                Console.WriteLine("No matches");
                return;
            }

            var result = command == "max"
                ? filter.Max()
                : filter.Min();

            Console.WriteLine(Array.LastIndexOf(inputArray, result));
        }

        private static int[] Exchange(int[] inputArray, int index)
        {
            if (index < 0 || index >= inputArray.Length)
            {
                Console.WriteLine("Invalid index");
                return inputArray;
            }

            var left = inputArray.Take(index + 1);
            var right = inputArray.Skip(index + 1);
            return right.Concat(left).ToArray();
        }
        private static int[] FilterEvenOrOdd(int[] inputArray, string evenOrOdd)
        {
            return inputArray
                .Where(n => evenOrOdd == "even"
                        ? n % 2 == 0
                        : n % 2 == 1)
                        .ToArray();
        }

        private static void PrintArray(int[] inputArray)
        {
            var arrayString = string.Join(", ", inputArray);
            Console.WriteLine($"[{arrayString}]");
            //Console.WriteLine("[{0}]", string.Join(", ", inputArray));
        }

    }
}

