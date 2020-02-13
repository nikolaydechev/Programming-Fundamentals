namespace _1.MostFrequentNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class MostFrequentNumber
    {
        public static void Main()
        {
            var input = File.ReadAllLines(@"..\..\input.txt");
            
            foreach (var line in input)
            {
                int[] numbers = line.Split(' ').Select(int.Parse).ToArray();

                var number = 0;
                var maxCount = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    var count = 0;

                    for (int j = i; j < numbers.Length; j++)
                    {
                        if (numbers[j] == numbers[i])
                        {
                            count++;
                        }
                        if (count > maxCount)
                        {
                            maxCount = count;
                            number = numbers[j];
                        }
                    }
                }

                Console.WriteLine(number);
                File.AppendAllText(@"..\..\output.txt", number.ToString() + Environment.NewLine);
            }
        }
    }
}
