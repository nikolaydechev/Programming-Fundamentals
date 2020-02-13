namespace TextFilter
{
    using System;
    using System.Linq;

    public class TextFilter
    {
        public static void Main()
        {
            var bannedWords = Console.ReadLine();
            var inputText = Console.ReadLine();

            string[] banned = bannedWords.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var banWord in banned)
            {
                if (inputText.Contains(banWord))
                {
                    inputText = inputText.Replace(banWord, new string('*', banWord.Length));
                }
            }

            Console.WriteLine(inputText);
        }
    }
}
