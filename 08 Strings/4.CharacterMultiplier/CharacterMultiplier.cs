namespace _4.CharacterMultiplier
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CharacterMultiplier
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string[] inputText = input.Split(' ').ToArray();

            var result = UnicodeCharacters(inputText[0], inputText[1]);
            var sum = 0;

            for (int i = 0; i < result.Count; i++)
            {
                sum += result[i];
            }

            Console.WriteLine(sum);
        }

        public static List<int> UnicodeCharacters(string firstWord, string secondWord)
        {
            var unicodeNumbers = new List<int>();
            foreach (var character in firstWord)
            {
                var unicode = (int)(character);
                unicodeNumbers.Add(unicode);
            }

            var unicodeSecondNumbers = new List<int>();
            foreach (var character in secondWord)
            {
                var unicode = (int)(character);
                unicodeSecondNumbers.Add(unicode);
            }

            var multipliedCharacters = new List<int>();

            if (firstWord.Length == secondWord.Length)
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                    var multiplied = firstWord[i] * secondWord[i];
                    multipliedCharacters.Add(multiplied);
                }
            }
            else if (firstWord.Length < secondWord.Length)
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                    var multiplied = firstWord[i] * secondWord[i];
                    multipliedCharacters.Add(multiplied);
                }
                for (int i = firstWord.Length ; i < secondWord.Length; i++)
                {
                    multipliedCharacters.Add(secondWord[i]);
                }
            }
            else if (secondWord.Length < firstWord.Length)
            {
                for (int i = 0; i < secondWord.Length; i++)
                {
                    var multiplied = firstWord[i] * secondWord[i];
                    multipliedCharacters.Add(multiplied);
                }
                for (int i = secondWord.Length; i < firstWord.Length; i++)
                {
                    multipliedCharacters.Add(firstWord[i]);
                }
            }

            return multipliedCharacters;
        }
    }
}
