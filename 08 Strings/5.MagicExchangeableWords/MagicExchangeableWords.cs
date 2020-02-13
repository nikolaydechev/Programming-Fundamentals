namespace _5.MagicExchangeableWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MagicExchangeableWords
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string[] inputText = input.Split(' ').ToArray();

            var result = UnicodeCharacters(inputText[0], inputText[1]);
            if (result)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        public static bool UnicodeCharacters(string firstWord, string secondWord)
        {
            bool exchangeable = true;
            var minLength = Math.Min(firstWord.Length, secondWord.Length);
            var commonList = new Dictionary<char, char>();

            for (int i = 0; i < minLength; i++)
            {
                if (!commonList.ContainsKey(firstWord[i]))
                {
                    if (!commonList.ContainsValue(secondWord[i]))
                    {
                        commonList.Add(firstWord[i], secondWord[i]);
                    }
                    else
                    {
                        exchangeable = false;
                        break;
                    }
                }
                else
                {
                    if (commonList[firstWord[i]] != secondWord[i])
                    {
                        exchangeable = false;
                        break;
                    }
                }
            }

            string restOfWord = "";

            if (firstWord.Length > secondWord.Length)
            {
                restOfWord = firstWord.Substring(minLength);
            }
            else
            {
                restOfWord = secondWord.Substring(minLength);
            }

            foreach (var character in restOfWord)
            {
                if (!commonList.ContainsKey(character) && !commonList.ContainsValue(character))
                {
                    exchangeable = false;
                }
            }

            return exchangeable;
        }
    }
}
