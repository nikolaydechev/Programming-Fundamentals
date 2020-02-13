namespace Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Palindromes
    {
        public static void Main()
        {
            var inputText = Console.ReadLine();
            string[] text = inputText.Split(new char[] { ' ', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var palindromes = new List<string>();

            foreach (var word in text)
            {
                var reversedWord = string.Join("", word.Reverse());

                if (reversedWord == word)
                {
                    palindromes.Add(reversedWord);
                }
            }
            
            Console.WriteLine(string.Join(", ", palindromes.OrderBy(x=>x).Distinct()));
        }
    }
}
