namespace _4.MaxSequence_of_EqualElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class MaxSeqOfEqualElements
    {
        public static void Main()
        {
            var input = File.ReadAllLines(@"..\..\input.txt");

            foreach (var line in input)
            {
                int[] numbers = line.Split(' ').Select(int.Parse).ToArray();
                var count = 0;
                var maxCount = 0;
                var element = 0;

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        count++;
                        if (count > maxCount)
                        {
                            maxCount = count;
                            element = numbers[i];
                        }
                    }
                    else
                    {
                        count = 0;
                    }
                }
                for (int i = 0; i < maxCount; i++)
                {
                    File.AppendAllText(@"..\..\output.txt", element + " ");
                }
                File.AppendAllText(@"..\..\output.txt", element + " "+ Environment.NewLine);
            }

        }
    }
}
