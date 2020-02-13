using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.RageQuit
{
    public class RageQuit
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            string numbersPattern = @"[0-9]+";
            var numbers = Regex.Matches(input, numbersPattern);
            var numbersList = new List<int>();
            foreach (Match number in numbers)
            {
                numbersList.Add(int.Parse(number.Value));
            }

            string textPattern = @"[A-Za-z\W|_]+";
            var gibberishes = Regex.Matches(input, textPattern);
            var gibberishesList = new List<string>();
            foreach (Match gibberish in gibberishes)
            {
                gibberishesList.Add(gibberish.Value.ToUpper());
            }
           
            StringBuilder result = new StringBuilder();
            
            for (int i = 0; i < gibberishesList.Count; i++)
            {
                var counts = numbersList[i];
                for (int j = 0; j < counts; j++)
                {
                    result.Append(gibberishesList[i]);
                }

            }
            Console.WriteLine($"Unique symbols used: {result.ToString().Distinct().Count()}");
            Console.WriteLine(result);

        }

        //
        // Another Solution:

        //static void Main(string[] args)
        //{
        //    var input = Console.ReadLine();
        //    StringBuilder result = new StringBuilder();

        //    Regex regex = new Regex(@"(\D+)(\d+)");
        //    MatchCollection matches = regex.Matches(input);

        //    foreach (Match item in matches)
        //    {
        //        var gibberish = item.Groups[1].Value;
        //        int multiplier = int.Parse(item.Groups[2].Value);
        //        result.Append(Multiply(gibberish, multiplier));

        //    }

        //    int count = result.ToString().Distinct().Count();

        //    Console.WriteLine("Unique symbols used: {0}", count);
        //    Console.WriteLine(result);
        //}

        //private static string Multiply(string gibberish, int multiplier)
        //{
        //    var result = "";
        //    for (int i = 0; i < multiplier; i++)
        //    {
        //        gibberish = gibberish.ToUpper();
        //        result += gibberish;
        //    }

        //    return result;
        //}
    }
}
