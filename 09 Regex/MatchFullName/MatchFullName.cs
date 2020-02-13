namespace MatchFullName
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchFullName
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            
            while (input != "end")
            {
                var pattern = @"<a.*href=(.*)>(.*?)<\/a>";

                var result = Regex.Replace(input, pattern, @"[URL href=$1]$2[/URL]");

                Console.WriteLine(result);

                input = Console.ReadLine();
            }
        }
    }
}
