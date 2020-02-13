using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CommandInterpreter
{
    public class CommandInterpreter
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ', '\r', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var command = Console.ReadLine();

            while (!command.Equals("end"))
            {
                string[] commmandArgs = command.Split().ToArray();

                var action = commmandArgs[0];
                var start = 0;
                var count = 0;

                switch (action)
                {
                    case "reverse":
                        start = int.Parse(commmandArgs[2]);
                        count = int.Parse(commmandArgs[4]);

                        if (IsValid(input, start, count))
                        {
                            //ReverseNumbers(input, start, count);
                            input.Reverse(start, count);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;

                    case "sort":
                        start = int.Parse(commmandArgs[2]);
                        count = int.Parse(commmandArgs[4]);
                        if (IsValid(input, start, count))
                        {
                            //input.Sort(start, count, StringComparer.InvariantCulture);
                            SortNumbers(input, start, count);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;

                    case "rollLeft":
                        count = int.Parse(commmandArgs[1]);
                        if (count >= 0)
                        {
                            RotateToLeft(input, count);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;

                    case "rollRight":
                        count = int.Parse(commmandArgs[1]);
                        if (count >= 0)
                        {
                            RotateToRight(input, count);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                }

                command = Console.ReadLine();

            }
            PrintingResults(input);
        }

        private static bool IsValid(List<string> input, int start, int count)
        {
            if (start >= 0 && start < input.Count && count >= 0 && (count + start) <= input.Count)
            {
                return true;
            }
            return false;
        }

        private static void PrintingResults(List<string> input)
        {
            Console.WriteLine("[{0}]", string.Join(", ", input));
        }

        private static void RotateToRight(List<string> input, int count)
        {
            count = count % input.Count;

            //for (int i = 0; i < count; i++)
            //{
            //    var lastElement = input[input.Count - 1];
            //    input.RemoveAt(input.Count - 1);
            //    input.Insert(0, lastElement);
            //}

            for (int i = 0; i < count; i++)
            {
                var lastElement = input[input.Count - 1];

                for (int j = input.Count - 1; j > 0; j--)
                {
                    input[j] = input[j - 1];
                }
                input[0] = lastElement;
            }
        }

        private static void RotateToLeft(List<string> input, int count)
        {
            count = count % input.Count;

            for (int i = 0; i < count; i++)
            {
                var firstElement = input[0];

                for (int j = 0; j < input.Count - 1; j++)
                {
                    input[j] = input[j + 1];
                }
                input[input.Count - 1] = firstElement;
            }
        }

        private static void SortNumbers(List<string> input, int start, int count)
        {
            List<string> resultInput = input.Skip(start).Take(count).OrderBy(x => x).ToList();
            input.RemoveRange(start, count);
            input.InsertRange(start, resultInput);
        }

        private static void ReverseNumbers(List<string> input, int start, int count)
        {
            input.Reverse(start, count);
            //List<string> resultInput = input.Skip(start).Take(count).Reverse().ToList();
            //input.RemoveRange(start, count);
            //input.InsertRange(start, resultInput);
        }
    }
}
