using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.LadyBugs
{
    public class LadyBugs
    {
        public static void Main()
        {
            var sizeOfField = int.Parse(Console.ReadLine());
            var ladyBugsIndexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var command = Console.ReadLine();

            var field = new List<int>(sizeOfField);
            for (int i = 0; i < sizeOfField; i++)
            {
                field.Add(0);
            }

            for (int i = 0; i < ladyBugsIndexes.Length; i++)
            {
                for (int j = 0; j < field.Count; j++)
                {
                    if (ladyBugsIndexes[i] == j)
                    {
                        field[j] = 1;
                    }
                }
            }

            while (!command.Equals("end"))
            {
                string[] commandLine = command.Split(' ').ToArray();
                var startIndex = int.Parse(commandLine[0]);
                var direction = commandLine[1];
                var flyingNumber = int.Parse(commandLine[2]);

                if (direction == "right")
                {
                    MoveToRight(field, startIndex, flyingNumber);
                }
                else if (direction == "left")
                {
                    MoveToLeft(field, startIndex, flyingNumber);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));

        }


        private static void MoveToLeft(List<int> field, int startIndex, int flyingNumber)
        {
            bool replaced = false;
            for (int i = startIndex; i >= 0; i--)
            {
                if (replaced == true)
                {
                    break;
                }
                if (startIndex < 0 || startIndex >= field.Count)
                {
                    break;
                }
                if (field[startIndex] == 1)
                {
                    field[startIndex] = 0;
                    var ladybugNewPlace = startIndex - flyingNumber;
                    if (ladybugNewPlace < 0 && ladybugNewPlace >= field.Count)
                    {
                        replaced = true;
                        break;
                    }
                    if (field[ladybugNewPlace] == 0)
                    {
                        field[ladybugNewPlace] = 1;
                        break;
                    }
                    else
                    {
                        if (startIndex < ladybugNewPlace)
                        {
                            for (int j = ladybugNewPlace; j < field.Count; j += flyingNumber)
                            {
                                if (field[j] == 0)
                                {
                                    field[j] = 1;
                                    replaced = true;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            for (int j = ladybugNewPlace; j >= 0; j -= flyingNumber)
                            {
                                if (field[j] == 0)
                                {
                                    field[j] = 1;
                                    replaced = true;
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    break;
                }
            }
        }

        private static void MoveToRight(List<int> field, int startIndex, int flyingNumber)
        {
            bool replaced = false;
            for (int i = startIndex; i < field.Count; i++)
            {
                if (replaced == true)
                {
                    break;
                }
                if (startIndex < 0 || startIndex >= field.Count)
                {
                    break;
                }
                if (field[startIndex] == 1)
                {
                    field[startIndex] = 0;
                    var ladybugNewPlace = startIndex + flyingNumber;

                    if (!(ladybugNewPlace >= 0 && ladybugNewPlace < field.Count))
                    {
                        replaced = true;
                        break;
                    }
                    if (field[ladybugNewPlace] == 0)
                    {
                        field[ladybugNewPlace] = 1;
                        break;
                    }
                    else
                    {
                        for (int j = ladybugNewPlace; j < field.Count; j += flyingNumber)
                        {
                            if (field[j] == 0)
                            {
                                field[j] = 1;
                                replaced = true;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}
