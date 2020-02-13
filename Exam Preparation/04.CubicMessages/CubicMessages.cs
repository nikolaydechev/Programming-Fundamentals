﻿using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.CubicMessages
{
    public class CubicMessages
    {
        public static void Main()
        {

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Over!")
                {
                    break;
                }
                var count = int.Parse(Console.ReadLine());

                var regex = new Regex($@"^(\d+)([A-Za-z]{{{count}}})([^A-Za-z]*)$");

                var match = regex.Match(input);
                if (match.Success)
                {
                    var left = match.Groups[1].Value;
                    var message = match.Groups[2].Value;
                    var right = match.Groups[3].Value;

                    var indexes = string.Concat(left, right)
                        .Where(char.IsDigit) //s => char.IsDigit(s)
                        .Select(s => s - '0'); //парсване на char към истинскo числo

                    var result = new StringBuilder();

                    foreach (var index in indexes)
                    {
                        if (index < 0 || index >= message.Length)
                        {
                            result.Append(' ');
                        }
                        else
                        {
                            result.Append(message[index]);
                        }
                    }

                    Console.WriteLine($"{message} == {result}");
                }
            }
        }
    }
}
