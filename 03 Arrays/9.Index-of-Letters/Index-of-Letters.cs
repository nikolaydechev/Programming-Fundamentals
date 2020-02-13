using System;

namespace _9.Index_of_Letters
{
    class Index_of_Letters
    {
        public static void Main()
        {
            char[] text = Console.ReadLine().ToCharArray();

            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine("{0} -> {1}", text[i], text[i] - 'a');
            }
        }
        public static void OtherSolution()
        {
            string word = Console.ReadLine().ToLower();
            char[] numAlphabet = new char[26];

            for (int i = 0; i < numAlphabet.Length; i++)
            {
                numAlphabet[i] = (char)('a' + i);
            }

            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(word[i] + " -> " + Array.IndexOf(numAlphabet, word[i]));
            }
        }
    }
}
