using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.RoliTheCoder
{
    public class RoliTheCoder
    {
        public static void Main()
        {
            var idEventParticipants = new SortedDictionary<int, SortedDictionary<string, List<string>>>();
          
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Time for Code")
                {
                    break;
                }
                string[] dataInput = input
                    .Split(new char[] { ' ', '\r', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToArray();

                var id = int.Parse(dataInput[0]);

                if (!dataInput[1].Contains("#"))
                {
                    continue;
                }

                var eventName = dataInput[1].Replace("#", "");

                if (idEventParticipants.ContainsKey(id))
                {
                    if (idEventParticipants[id].ContainsKey(eventName))
                    {
                        for (int i = 2; i < dataInput.Length; i++)
                        {
                            if (!idEventParticipants[id][eventName].Contains(dataInput[i]))
                            {
                                idEventParticipants[id][eventName].Add(dataInput[i]);
                            }
                        }
                    }
                }
                if (!idEventParticipants.ContainsKey(id))
                {
                    idEventParticipants[id] = new SortedDictionary<string, List<string>>();
                    idEventParticipants[id][eventName] = new List<string>();
                    
                    for (int i = 2; i < dataInput.Length; i++)
                    {
                        idEventParticipants[id][eventName].Add(dataInput[i]);
                    }
                }
            }

            foreach (var id in idEventParticipants.OrderByDescending(p => p.Value.Values.Sum(c => c.Count)).ThenBy(x => x.Key))
            {
                foreach (var item in id.Value)
                {
                    Console.WriteLine($"{item.Key} - {item.Value.Count}");
                    foreach (var person in item.Value.OrderBy(x => x).Distinct())
                    {
                        Console.WriteLine(string.Join("\n", person));
                    }
                }
            }
        }
    }
}
