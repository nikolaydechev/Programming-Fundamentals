namespace _9.TeamworkProjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TeamworkProjects
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            List<Team> teamList = new List<Team>();
            List<string> messages = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] inputText = input.Split('-');
                var teamCreator = inputText[0];
                var teamName = inputText[1];

                if (teamList.Any(x => x.TeamName == teamName))
                {
                    messages.Add($"Team {teamName} was already created!");
                }
                else if (teamList.Any(x => x.CreatorName == teamCreator))
                {
                    messages.Add($"{teamCreator} cannot create another team!");
                }
                else
                {
                    var team = new Team(teamCreator, teamName, new List<string>());
                    messages.Add($"Team {teamName} has been created by {teamCreator}!");
                    teamList.Add(team);
                }

                input = Console.ReadLine();
            }

            while (!input.Equals("end of assignment"))
            {
                string[] inputText = input.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var userName = inputText[0];
                var teamToJoin = inputText[1];
                List<string> newUsers = new List<string>();
                newUsers.Add(userName);

                if (!teamList.Select(x => x.TeamName).Contains(teamToJoin))
                {
                    messages.Add($"Team {teamToJoin} does not exist!");
                }
                else if (teamList.Select(x => x.CreatorName).Contains(userName) || teamList.Select(x => x.Members).Any(x => x.Contains(userName)))
                {
                    messages.Add($"Member {userName} cannot join team {teamToJoin}!");
                }
                else
                {
                    var currentTeam = teamList.Where(x => x.TeamName == teamToJoin).First();
                    currentTeam.Members.Add(userName);
                }

                input = Console.ReadLine();
            }

            //SORT

            var sortedTeams = teamList.OrderByDescending(x => x.Members.Count)
                                      .ThenBy(x => x.TeamName)
                                      .Where(x => x.Members.Count > 0)
                                      .ToList();

            var disbandTeams = teamList.Where(x => x.Members.Count == 0)
                                       .OrderBy(x => x.TeamName)
                                       .ToList();

            //PRINTING
            Console.WriteLine(string.Join(Environment.NewLine, messages));

            foreach (var team in sortedTeams)
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.CreatorName}");
                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine($"Teams to disband:");
            foreach (var team in disbandTeams)
            {
                Console.WriteLine($"{team.TeamName}");
            }
        }
    }
}
