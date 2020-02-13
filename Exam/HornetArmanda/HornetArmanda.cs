using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetArmanda
{
    class HornetArmanda
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var legionInfo = new Dictionary<string, Dictionary<string, int>>();
            var lastActivityAndLegion = new Dictionary<int, string>();

            List<Legion> legions = new List<Legion>();
            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine();
                var legionsArg = input.Split(new[] { ' ', ':', '=', }, StringSplitOptions.RemoveEmptyEntries);
                Array.ForEach<string>(legionsArg, x => legionsArg[Array.IndexOf<string>(legionsArg, x)] = x.Trim());
                var lastActivity = int.Parse(legionsArg[0]);
                var legionName = legionsArg[1];
                var soldierType = legionsArg[3];
                var soldierCount = int.Parse(legionsArg[4]);

                if (!legionInfo.ContainsKey(legionName))
                {
                    legionInfo[legionName] = new Dictionary<string, int>();
                    legionInfo[legionName].Add(soldierType, soldierCount);
                }
                else if (legionInfo[legionName].ContainsKey(soldierType))
                {
                    legionInfo[legionName][soldierType] += soldierCount;
                }
                else
                {
                    legionInfo[legionName].Add(soldierType, soldierCount);
                }

                
            }

            var modified = legionInfo.Where()

            foreach (var item   in legionInfo)
            {
                Console.Write($"{item.Key} -> ");
                foreach (var kvp  in item.Value)
                {
                    Console.WriteLine($"{kvp.Value}");
                }
            }
        }
    }
}
