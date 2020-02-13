namespace ReverseString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Strings
    {
        public static void Main()
        {
            var word = Console.ReadLine();
            
            Console.WriteLine(string.Join("",word.Reverse()));

            //var wordToChar = word.ToCharArray();
            //Array.Reverse(wordToChar);
            //Console.WriteLine(wordToChar);
        }
    }
}
