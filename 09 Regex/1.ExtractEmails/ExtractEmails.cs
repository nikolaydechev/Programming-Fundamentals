namespace _1.ExtractEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class ExtractEmails
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"([\w.-]+\@[A-Za-z-]+)(\.[A-Za-z-]+)+";

            var regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            foreach (var match in matches)
            {
                string matchString = match.ToString();
                
                if (!(matchString.StartsWith("-") || matchString.StartsWith(".") || matchString.StartsWith("_")
                    || matchString.EndsWith("-") || matchString.EndsWith(".") || matchString.EndsWith("_")))
                {
                    Console.WriteLine(matchString);
                }
            }
        }
    }
}
