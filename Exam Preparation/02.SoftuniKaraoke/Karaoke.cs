namespace _02.SoftuniKaraoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Karaoke
    {
        public static void Main()
        {
            string participants = Console.ReadLine();
            string[] participant = participants.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var allParticipants = new List<string>();
            for (int i = 0; i < participant.Length; i++)
            {
                allParticipants.Add(participant[i]);
            }

            string songs = Console.ReadLine();
            string[] song = songs.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);//.Select(s => s.Trim())
            Array.ForEach<string>(song, x => song[Array.IndexOf<string>(song, x)] = x.Trim());

            var allSongs = new List<string>();
            for (int i = 0; i < song.Length; i++)
            {
                allSongs.Add(song[i]);
            }

            string input = Console.ReadLine();
           

            var awards = new Dictionary<string, List<string>>();
            while (!input.Equals("dawn"))
            {
                string[] stagePerformance = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);//.Select(s => s.Trim())
                Array.ForEach<string>(stagePerformance, x => stagePerformance[Array.IndexOf<string>(stagePerformance, x)] = x.Trim());
                var participantName = stagePerformance[0];
                var songName = stagePerformance[1];
                var award = stagePerformance[2];

                if (allParticipants.Contains(participantName) && allSongs.Contains(songName) && !awards.ContainsKey(participantName))
                {
                    awards[participantName] = new List<string>();
                    awards[participantName].Add(award);
                }
                if (awards.ContainsKey(participantName) && allSongs.Contains(songName) && !awards[participantName].Contains(award))
                {
                    awards[participantName].Add(award);
                }

                input = Console.ReadLine();
            }

            //SORT
            //Participants should be sorted by number of awards in descending order.. 
            //..and then by participant name alphabetically.
            //Awards should be sorted in alphabetical order.

            var sortedParticipants = awards
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            //PRINTING
            if (awards.Any())
            {
                foreach (var person in sortedParticipants)
                {
                    Console.WriteLine($"{person.Key}: {person.Value.Count} awards");
                    Console.WriteLine($"--{string.Join("\n--", person.Value.OrderBy(x => x))}");
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
