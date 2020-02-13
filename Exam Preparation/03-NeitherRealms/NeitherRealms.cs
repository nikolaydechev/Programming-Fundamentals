using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03_NeitherRealms
{
    public class NeitherRealms
    {
        public static void Main()
        {
            string[] demons = Console.ReadLine()
                    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(d => d.Trim())
                    .ToArray();

            var demonBook = new SortedDictionary<string, Dictionary<double, double>>();
            
            foreach (var demon in demons)
            {
                string healthPattern = @"[^0-9+\-*\/\.]";
                var regex = new Regex(healthPattern);
                MatchCollection matches = regex.Matches(demon);

                var healthPoints = new List<string>();
                foreach (Match item in matches)
                {
                    healthPoints.Add(item.Value);
                }
                var health = 0;
                for (int i = 0; i < healthPoints.Count; i++)
                {
                    var asciiLetter = (int)healthPoints[i][0];
                    health += asciiLetter;
                }

                var damage = 0.0;
                string damagePatternNumbers = @"[+-]?\d+(?:\.?\d+)?";
                var damageNumMatches = Regex.Matches(demon, damagePatternNumbers);

                foreach (Match item in damageNumMatches)
                {
                    damage += double.Parse(item.Value);
                }
                var modifiers = demon.Where(a => a == '*' || a == '/').ToArray();

                foreach (var modifier in modifiers)
                {
                    if (modifier == '*')
                    {
                        damage *= 2;
                    }
                    else
                    {
                        damage /= 2;
                    }
                }

                demonBook[demon] = new Dictionary<double, double>();
                demonBook[demon].Add(health, damage);
            }

            foreach (var demon in demonBook)
            {
                Console.Write($"{demon.Key} - ");
                foreach (var kvp in demon.Value)
                {
                    Console.Write($"{kvp.Key} health, {kvp.Value:F2} damage");
                }
                Console.WriteLine();
            }
        }
    }
}
