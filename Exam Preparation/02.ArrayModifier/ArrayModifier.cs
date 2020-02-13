namespace _02.ArrayModifier
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayModifier
    {
        public static void Main()
        {
            // Problem 02 : Array Modifier

            long[] inputNumbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            var input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputArgs = input.Split().ToArray();

                var command = inputArgs[0];
                long firstIndex = 0;
                long secondIndex = 0;

                switch (command)
                {
                    case "swap":
                        firstIndex = long.Parse(inputArgs[1]);
                        secondIndex = long.Parse(inputArgs[2]);
                        inputNumbers = Swap(inputNumbers, firstIndex, secondIndex);
                        break;

                    case "multiply":
                        firstIndex = long.Parse(inputArgs[1]);
                        secondIndex = long.Parse(inputArgs[2]);
                        inputNumbers = Multiply(inputNumbers, firstIndex, secondIndex);
                        break;

                    case "decrease":
                        for (long i = 0; i < inputNumbers.Length; i++)
                        {
                            inputNumbers[i] = inputNumbers[i] - 1;
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", inputNumbers));
        }

        private static long[] Multiply(long[] inputNumbers, long firstIndex, long secondIndex)
        {
            inputNumbers[firstIndex] = inputNumbers[firstIndex] * inputNumbers[secondIndex];

            return inputNumbers;
        }

        private static long[] Swap(long[] inputNumbers, long firstIndex, long secondIndex)
        {
            var temp = inputNumbers[firstIndex];
            inputNumbers[firstIndex] = inputNumbers[secondIndex];
            inputNumbers[secondIndex] = temp;

            return inputNumbers;
        }
    }
}

