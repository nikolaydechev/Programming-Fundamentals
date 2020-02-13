using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04_WinningTicket
{
    public class WinningTicket
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ',', ' ', '\t', '\n', '\r', '\v', '\f' }, StringSplitOptions.RemoveEmptyEntries).ToArray();


            for (int i = 0; i < input.Length; i++)
            {
                var maxCountLeft = 0;
                var maxCountRight = 0;
                var leftCounter = 0;
                var rightCounter = 0;
                Match match = Regex.Match(input[i], @"[$#@^]");

                var firstHalfchars = input[i].Substring(0, input[i].Length / 2);
                var secondHalfchars = input[i].Substring(input[i].Length / 2, input[i].Length - input[i].Length / 2);
                
                for (int k = 0; k < firstHalfchars.Length; k++)
                {
                    if (firstHalfchars[k].ToString().Equals(match.ToString()))
                    {
                        leftCounter++;
                        if (maxCountLeft < leftCounter)
                        {
                            maxCountLeft = leftCounter;
                        }
                    }
                    else
                    {
                        leftCounter = 0;
                    }

                }
                for (int p = 0; p < secondHalfchars.Length; p++)
                {
                    if (secondHalfchars[p].ToString().Equals(match.ToString()))
                    {
                        rightCounter++;
                        if (maxCountRight < rightCounter)
                        {
                            maxCountRight = rightCounter;
                        }
                    }
                    else
                    {
                        rightCounter = 0;
                    }
                }


                //foreach (char character in firstHalfchars)
                //{
                //    if (character.ToString().Equals(match.ToString()))
                //    {
                //        leftCounter++;
                //    }
                //}
                //foreach (char character in secondHalfchars)
                //{
                //    if (character.ToString().Equals(match.ToString()))
                //    {
                //        rightCounter++;
                //    }
                //}

                if (input[i].Length == 20 && maxCountLeft < 6 || input[i].Length == 20 && maxCountRight < 6)
                {
                    Console.WriteLine($"ticket \"{input[i]}\" - no match");
                }
                else if (input[i].Length == 20 && maxCountLeft >= 6 && maxCountLeft <= 9 && maxCountLeft == maxCountRight)
                {
                    Console.WriteLine($"ticket \"{input[i]}\" - {maxCountLeft}{match}");
                }
                else if (input[i].Length == 20 && maxCountLeft == 10 && maxCountLeft == maxCountRight)
                {
                    Console.WriteLine($"ticket \"{input[i]}\" - {maxCountLeft}{match} Jackpot!");
                }
                else if (input[i].Length == 20 && maxCountLeft < maxCountRight && maxCountLeft >= 6 && maxCountLeft <= 9)
                {
                    Console.WriteLine($"ticket \"{input[i]}\" - {maxCountLeft}{match}");
                }
                else if (input[i].Length == 20 && maxCountRight < maxCountLeft && maxCountRight >= 6 && maxCountRight <= 9)
                {
                    Console.WriteLine($"ticket \"{input[i]}\" - {maxCountRight}{match}");
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                
                }
            }
        }


        // ANOTHER SOLUTION: 

        //public static void Main()
        //{
        //    var input = Console.ReadLine()
        //        .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
        //        .Select(x => x.Trim())
        //        .ToArray();

        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        if (input[i].Length == 20)
        //        {
        //            var leftHalf = new string(input[i].Take(10).ToArray());
        //            var rightHalf = new string(input[i].Skip(10).ToArray());

        //            var regex = new Regex(@"[@#$^]{6,10}");
        //            Match match = Regex.Match(input[i], @"[$#@^]");

        //            var leftMatch = regex.Match(leftHalf);
        //            var rightMatch = regex.Match(rightHalf);

        //            var leftSymbolsLength = leftMatch.Value.Length;
        //            var rightSymbolsLength = rightMatch.Value.Length;

        //            var left = Regex.Match(leftHalf, @"[$#@^]").ToString();
        //            var right = Regex.Match(rightHalf, @"[$#@^]").ToString();

        //            if (leftSymbolsLength < 6 || rightSymbolsLength < 6)
        //            {
        //                Console.WriteLine("ticket \"{0}\" - no match", input[i]);
        //                continue;
        //            }
        //            if (leftMatch.Success && rightMatch.Success)
        //            {
        //                if (leftSymbolsLength == 10 && rightSymbolsLength == 10)
        //                {
        //                    if (left == right)
        //                    {
        //                        Console.WriteLine($"ticket \"{input[i]}\" - 10{match} Jackpot!");
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("ticket \"{0}\" - no match", input[i]);
        //                    }
        //                }
        //                else
        //                {
        //                    if (left == right)
        //                    {
        //                        Console.WriteLine($"ticket \"{input[i]}\" - {Math.Min(leftSymbolsLength, rightSymbolsLength)}{match}");
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("ticket \"{0}\" - no match", input[i]);
        //                    }
        //                }
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("invalid ticket");
        //        }
        //    }
        //}
    }
}

