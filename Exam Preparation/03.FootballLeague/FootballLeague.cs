namespace _03.FootballLeague
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FootballLeague
    {
        public static void Main()
        {
            string key = Console.ReadLine();
            string input = Console.ReadLine();

            var teamsStandings = new Dictionary<string, int>();
            var teamsGoals = new Dictionary<string, int>();

            while (!input.Equals("final"))
            {
                string[] teams = input.Split(' ');
                var encryptedFirstTeam = teams[0];
                var encryptedSecondTeam = teams[1];
                var scoresResult = teams[2];

                var firstTeam = ExtractingTeamName(encryptedFirstTeam, key);
                var secondTeam = ExtractingTeamName(encryptedSecondTeam, key);

                if (!teamsStandings.ContainsKey(firstTeam))
                {
                    teamsStandings.Add(firstTeam, 0);
                    teamsGoals.Add(firstTeam, 0);
                }
                if (!teamsStandings.ContainsKey(secondTeam))
                {
                    teamsStandings.Add(secondTeam, 0);
                    teamsGoals.Add(secondTeam, 0);
                }

                string[] scores = scoresResult.Split(':');
                teamsGoals[firstTeam] += int.Parse(scores[0]);
                teamsGoals[secondTeam] += int.Parse(scores[1]);

                if (int.Parse(scores[0]) > int.Parse(scores[1]))
                {
                    teamsStandings[firstTeam] += 3;
                }
                else if (int.Parse(scores[0]) < int.Parse(scores[1]))
                {
                    teamsStandings[secondTeam] += 3;
                }
                else if (int.Parse(scores[0]) == int.Parse(scores[1]))
                {
                    teamsStandings[firstTeam] += 1;
                    teamsStandings[secondTeam] += 1;
                }
                
                input = Console.ReadLine();
            }

            var counter = 0;

            Console.WriteLine($"League standings:");

            foreach (var team in teamsStandings.OrderByDescending(x => x.Value).ThenBy(x=>x.Key))
            {
                counter++;
                Console.WriteLine($"{counter}. {team.Key} {team.Value}");
            }

            Console.WriteLine($"Top 3 scored goals:");

            foreach (var team in teamsGoals.OrderByDescending(x => x.Value).ThenBy(x=>x.Key).Take(3))
            {
                Console.WriteLine($"- {team.Key} -> {team.Value}");
            }
        }

        private static string ExtractingTeamName(string encryptedName, string key)
        {
            var startIndex = encryptedName.IndexOf(key) + key.Length;
            var endIndex = encryptedName.LastIndexOf(key);
            int length = endIndex - startIndex;
            string firstTeam = encryptedName.Substring(startIndex, length);
            return string.Join("", firstTeam.ToUpper().Reverse());
        }
    }


    // ANOTHER SOLUTION: 
    //public class Program
    //{
    //    public static void Main()
    //    {
    //        // Problem 3 : Football League

    //        var leagueData = new Dictionary<string, int>();
    //        var goalsData = new Dictionary<string, int>();

    //        var input = Console.ReadLine();
    //        var key = input;
    //        key = Regex.Escape(key);
    //        input = Console.ReadLine();

    //        while (input != "final")
    //        {
    //            string[] inputArgs = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

    //            var encryptedFirstTeam = inputArgs[0];
    //            var encryptedSecondTeam = inputArgs[1];
    //            var matchResult = inputArgs[2];

    //            string[] matchResultArgs = matchResult.Split(':');
    //            var firstTeamScore = int.Parse(matchResultArgs[0]);
    //            var secondTeamScore = int.Parse(matchResultArgs[1]);

    //            Regex regex = new Regex($@"{key}(.+?){key}");

    //            Match firstMatch = regex.Match(encryptedFirstTeam);
    //            var firstTeam = firstMatch.Groups[1].Value.ToUpper().ToString();
    //            firstTeam = ReverseString(firstTeam);
    //            // var firstTeamReversed = firstmatch.Groups[1].Value.Reverse().ToArray();
    //            // var firstTeam = new string(firstTeamReversed).ToUpper();
    //            Match secondMatch = regex.Match(encryptedSecondTeam);
    //            var secondTeam = secondMatch.Groups[1].Value.ToUpper().ToString();
    //            secondTeam = ReverseString(secondTeam);

    //            if (!leagueData.ContainsKey(firstTeam))
    //            {
    //                leagueData.Add(firstTeam, 0);
    //                goalsData.Add(firstTeam, 0);
    //            }
    //            if (!leagueData.ContainsKey(secondTeam))
    //            {
    //                leagueData.Add(secondTeam, 0);
    //                goalsData.Add(secondTeam, 0);
    //            }

    //            goalsData[firstTeam] += firstTeamScore;
    //            goalsData[secondTeam] += secondTeamScore;

    //            if (firstTeamScore > secondTeamScore)
    //            {
    //                leagueData[firstTeam] += 3;
    //            }
    //            else if (firstTeamScore < secondTeamScore)
    //            {
    //                leagueData[secondTeam] += 3;
    //            }
    //            else
    //            {
    //                leagueData[firstTeam] += 1;
    //                leagueData[secondTeam] += 1;
    //            }

    //            input = Console.ReadLine();
    //        }

    //        var position = 1;

    //        Console.WriteLine("League standings:");
    //        foreach (var team in leagueData.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
    //        {
    //            Console.WriteLine($"{position}. {team.Key} {team.Value}");
    //            position++;
    //        }

    //        Console.WriteLine("Top 3 scored goals:");
    //        foreach (var team in goalsData.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Take(3))
    //        {
    //            Console.WriteLine($"- {team.Key} -> {team.Value}");
    //        }
    //    }

    //    private static string ReverseString(string firstTeam)
    //    {
    //        char[] charArray = firstTeam.ToCharArray();
    //        Array.Reverse(charArray);
    //        return new string(charArray);
    //    }
    //}
}
