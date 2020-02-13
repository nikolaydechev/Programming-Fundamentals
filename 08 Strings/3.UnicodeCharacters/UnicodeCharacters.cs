namespace _3.UnicodeCharacters
{
    using System;

    public class UnicodeCharacters
    {
        public static void Main()
        {
            var word = Console.ReadLine().ToCharArray();
            
            foreach (var character in word)
            {
                Console.Write($"\\u{(int)character:x4}");
            }

            Console.WriteLine();
        }
    }
}
