namespace _8.LettersChangeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LettersChangeNumbers
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string[] inputText = input.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var upperLettersPosition = new Dictionary<char, int>();
            var lowerLettersPosition = new Dictionary<char, int>();

            for (int i = 0; i < 26; i++)
            {
                upperLettersPosition.Add((char)('A' + i), i + 1);
            }
            for (int i = 0; i < 26; i++)
            {
                lowerLettersPosition.Add((char)('a' + i), i + 1);
            }

            var totalSum = new List<decimal>();

            foreach (var item in inputText)
            {
                char firstNumLetter = item.First();
                char secondNumLetter = item.Last();
                var number = item.Substring(1, item.Length - 2);

                if (char.IsUpper(firstNumLetter))
                {
                    var firstProduct = decimal.Parse(number) / upperLettersPosition[firstNumLetter];

                    if (char.IsLower(secondNumLetter))
                    {
                        var firstSum = firstProduct + lowerLettersPosition[secondNumLetter];
                        totalSum.Add(firstSum);
                    }
                    else
                    {
                        var firstSum = firstProduct - upperLettersPosition[secondNumLetter];
                        totalSum.Add(firstSum);
                    }
                }
                else
                {
                    var firstProduct = decimal.Parse(number) * lowerLettersPosition[firstNumLetter];

                    if (char.IsLower(secondNumLetter))
                    {
                        var firstSum = firstProduct + lowerLettersPosition[secondNumLetter];
                        totalSum.Add(firstSum);
                    }
                    else
                    {
                        var firstSum = firstProduct - upperLettersPosition[secondNumLetter];
                        totalSum.Add(firstSum);
                    }
                }
            }

            decimal total = 0;
            foreach (var number in totalSum)
            {
                total += number;
            }
            Console.WriteLine($"{total:f2}");
        }
    }
}
