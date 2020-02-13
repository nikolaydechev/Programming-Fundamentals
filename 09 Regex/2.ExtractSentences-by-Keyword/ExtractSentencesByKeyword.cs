namespace _2.ExtractSentences_by_Keyword
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractSentencesByKeyword
    {
        public static void Main()
        {
            string word = Console.ReadLine();
            string[] sentences = Console.ReadLine().Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            string pattern = "\\b" + word + "\\b";

            var regex = new Regex(pattern);

            foreach (var sentence in sentences)
            {
                if (regex.IsMatch(sentence))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
