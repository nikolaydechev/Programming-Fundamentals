namespace _2.IndexOfLetters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class IndexOfLetters
    {
        public static void Main()
        {
            var input = File.ReadAllLines(@"..\..\input.txt");

            foreach (var line in input)
            {
                char[] letters = line.ToCharArray();
                for (int i = 0; i < letters.Length; i++)
                {
                    var letter = letters[i];
                    var number = letters[i] - 'a';
                    var result = string.Format($"{letter} -> {number}");
                    File.AppendAllText(@"..\..\output.txt", result + Environment.NewLine);
                }
            }
        }
    }
}
