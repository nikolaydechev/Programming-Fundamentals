using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HornetComm
{
    public class HornetComm
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var PrivateMessage = new Dictionary<string, List<string>>();
            var broadcast = new Dictionary<string, List<string>>();

            while (!input.Equals("Hornet is Green"))
            {
                string[] inputArgs = input.Split(new[] { ' ', '\r', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                Array.ForEach<string>(inputArgs, x => inputArgs[Array.IndexOf<string>(inputArgs, x)] = x.Trim());
                var firstQuery = inputArgs[0];
                var secondQuery = inputArgs[2];

                //PrivateMessageFirstQueryCheck(firstQuery);
               // PrivateMessageSecondQueryCheck(secondQuery);

                if (PrivateMessageFirstQueryCheck(firstQuery) && PrivateMessageSecondQueryCheck(secondQuery))
                {
                    var first = ReverseRecipientCode(firstQuery);
                    if (!PrivateMessage.ContainsKey(first))
                    {
                        PrivateMessage[first] = new List<string>();
                        PrivateMessage[first].Add(secondQuery);
                    }
                    else
                    {
                        PrivateMessage[first].Add(secondQuery);
                    }
                }

                //BroadcastFirstQueryCheck(firstQuery);
                //BroadcastSecondQueryCheck(secondQuery);
                if (BroadcastFirstQueryCheck(firstQuery) && BroadcastSecondQueryCheck(secondQuery))
                {
                    var first = CheckingLetters(secondQuery);
                    if (!broadcast.ContainsKey(first))
                    {
                        broadcast[first] = new List<string>();
                        broadcast[first].Add(firstQuery);
                    }
                    else
                    {
                        broadcast[first].Add(firstQuery);
                    }
                }
                input = Console.ReadLine();
            }

            PrintingResults(PrivateMessage, broadcast);
        }

        private static void PrintingResults(Dictionary<string, List<string>> privateMessage, Dictionary<string, List<string>> broadcast)
        {
            if (broadcast.Count == 0)
            {
                Console.WriteLine("Broadcasts:");
                Console.WriteLine("None");
            }
            else
            {
                Console.WriteLine("Broadcasts:");
                foreach (var item in broadcast)
                {
                    foreach (var kvp in item.Value)
                    {
                        Console.WriteLine($"{item.Key} -> {kvp}", string.Join("\n", item.Value));
                    }
                }
            }
            if (privateMessage.Count == 0)
            {
                Console.WriteLine("Messages:");
                Console.WriteLine("None");
            }
            else
            {
                Console.WriteLine("Messages:");
                foreach (var item in privateMessage)
                {
                    foreach (var kvp in item.Value)
                    {
                        Console.WriteLine($"{item.Key} -> {kvp}", string.Join("\n", item.Value));
                    }
                }
            }
        }

        private static string CheckingLetters(string secondQuery)
        {
            // char[] secArray = secondQuery.ToCharArray();
            //string[] secQueryArr = new string[] { secondQuery };
            var modifiedWord = new StringBuilder();
            for (int i = 0; i < secondQuery.Length; i++)
            {
                if (char.IsLower(secondQuery, i))
                {
                    var letter = char.ToUpper(secondQuery[i]);
                    modifiedWord.Append(letter);
                }
                else if (char.IsUpper(secondQuery, i))
                {
                    var letter = char.ToLower(secondQuery[i]);
                    modifiedWord.Append(letter);
                }
                else
                {
                    modifiedWord.Append(secondQuery[i]);
                }

            }
            return modifiedWord.ToString();
        }

        private static bool BroadcastSecondQueryCheck(string secondQuery)
        {
            var secondQueryPattern = @"^[a-zA-Z0-9]+$";//@"(^[A-Za-z]+)?([0-9]+)?"; //@"^[a-zA-Z0-9]+$"; 
            var regex = new Regex(secondQueryPattern);
            bool matched = false;
            if (regex.IsMatch(secondQuery))
            {
                matched = true;
            }
            return matched;
        }

        private static bool BroadcastFirstQueryCheck(string firstQuery)
        {
            var firstQueryPattern = @"[^0-9]";
            var regex = new Regex(firstQueryPattern);
            bool matched = false;
            if (regex.IsMatch(firstQuery))
            {
                matched = true;
            }
            return matched;
        }

        private static string ReverseRecipientCode(string firstQuery)
        {
            char[] charrArray = firstQuery.ToCharArray();
            Array.Reverse(charrArray);
            return new string(charrArray);
        }

        private static bool PrivateMessageSecondQueryCheck(string secondQuery)
        {
            var secondQueryPattern = @"^[a-zA-Z0-9]+$"; // @"([0-9]+)?([A-Za-z]+)?";  //@" ^[a-zA-Z0-9]+$";
            var regex = new Regex(secondQueryPattern);
            bool matched = false;
            if (regex.IsMatch(secondQuery))
            {
                matched = true;
            }
            return matched;
        }

        private static bool PrivateMessageFirstQueryCheck(string firstQuery)
        {
            var firstQueryPattern = @"^[0-9]*$";
            var reg = new Regex(firstQueryPattern);
            bool matched = false;
            if (reg.IsMatch(firstQuery))
            {
                matched = true;
            }
            return matched;
        }
    }
}
