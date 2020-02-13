namespace _03_EnduranceRally
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EnduranceRally
    {
        public static void Main()
        {
            string[] participants = Console.ReadLine().Split(' ').ToArray();
            var trackLayout = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var checkpoints = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var asciiLetters = new List<int>();
            var fuelQuantity = new Dictionary<string, double>();
            var notSucceed = new List<string>();

            //foreach (var participant in participants)
            //{
            //    int fuel = participant.First();
            //    //CODE
            //}

            for (int i = 0; i < participants.Length; i++)
            {
                var firstLetter = (int)participants[i][0];
                asciiLetters.Add(firstLetter);
            }

            for (int i = 0; i < asciiLetters.Count; i++)
            {
                var lastIndex = 0;
                double fuel = asciiLetters[i];

                for (int j = 0; j < trackLayout.Count; j++)
                {
                    var currentZoneFuel = trackLayout[j];

                    if (checkpoints.Contains(j))
                    {
                        fuel += currentZoneFuel;
                    }
                    else
                    {
                        fuel -= currentZoneFuel;
                    }
                    if (fuel <= 0)
                    {
                        fuel = 0;
                        lastIndex = j;
                        break;
                    }
                }
                if (fuel > 0)
                {
                    fuelQuantity.Add(participants[i], fuel);
                }
                else
                {
                    fuelQuantity.Add(participants[i], lastIndex);
                }
                if (fuel <= 0)
                {
                    notSucceed.Add(participants[i]);
                }
            }

            //PRINTING

            foreach (var participant in fuelQuantity)
            {
                if (notSucceed.Contains(participant.Key))
                {
                    Console.WriteLine($"{participant.Key} - reached {participant.Value}");
                }
                else
                {
                    Console.WriteLine($"{participant.Key} - fuel left {participant.Value:f2}");
                }
            }
        }
    }
}
