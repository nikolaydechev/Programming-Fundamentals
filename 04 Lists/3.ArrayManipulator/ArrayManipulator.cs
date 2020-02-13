namespace _3.ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ArrayManipulator
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var sumPairsList = new List<int>();

            string command = Console.ReadLine();

            while (!command.Equals("print"))
            {
                string[] commandLine = command.Split(' ');

                if (commandLine[0].Equals("add"))
                {
                    var index = int.Parse(commandLine[1]);
                    var element = int.Parse(commandLine[2]);

                    numbers.Insert(index, element);
                }

                if (commandLine[0].Equals("addMany"))
                {
                    var index = int.Parse(commandLine[1]);

                    for (int i = 0; i < commandLine.Length - 2; i++)
                    {
                        var element = int.Parse(commandLine[i + 2]);
                        numbers.Insert(index + i, element);
                    }
                }

                if (commandLine[0].Equals("contains"))
                {
                    var element = int.Parse(commandLine[1]);
                    if (numbers.Contains(element))
                    {
                        int index = numbers.IndexOf(element);
                        Console.WriteLine(index);
                    }
                    else
                    {
                        Console.WriteLine("-1");
                    }
                }

                if (commandLine[0].Equals("remove"))
                {
                    var index = int.Parse(commandLine[1]);
                    numbers.RemoveAt(index);
                }

                if (commandLine[0].Equals("shift"))
                {
                    var element = int.Parse(commandLine[1]);
                    int index = numbers.IndexOf(element);
                    if (index - element >= 0 && index - element <= numbers.Count)
                    {
                        numbers.RemoveAt(index);
                        numbers.Insert(index - element, element);
                    }
                    else
                    {
                        for (int i = 0; i < element; i++)
                        {
                            var firstElement = numbers[0];
                            for (int j = 0; j < numbers.Count - 1; j++)
                            {
                                numbers[j] = numbers[j + 1];
                            }
                            numbers[numbers.Count - 1] = firstElement;
                        }
                    }
                }

                if (commandLine[0].Equals("sumPairs"))
                {
                    var sumPair = 0;
                    var count = numbers.Count;

                    if (numbers.Count % 2 == 0)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            sumPair = numbers[0] + numbers[1];
                            sumPairsList.Add(sumPair);
                            numbers.RemoveAt(0);
                            numbers.RemoveAt(0);


                            if (numbers.Count == 0)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        while (numbers.Count > 1)
                        {
                            sumPair = numbers[0] + numbers[1];
                            sumPairsList.Add(sumPair);
                            numbers.RemoveAt(0);
                            numbers.RemoveAt(0);
                        }
                        sumPairsList.Add(numbers[0]);

                    }

                    numbers = sumPairsList;
                    sumPairsList = new List<int>();

                }

                command = Console.ReadLine();
            }
            Console.Write("[");
            Console.Write(string.Join(", ", numbers));
            Console.WriteLine("]");
        }

    }
}
