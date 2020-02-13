using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetAssault
{
    public class HornetAssault
    {
        public static void Main()
        {
            // Problem 3: Hornet Assault

            var beehives = Console.ReadLine().Split().Select(long.Parse).ToList();
            var hornets = Console.ReadLine().Split().Select(long.Parse).ToList();

            var leftBeehives = new List<long>();

            var hornetsPower = hornets.Sum();

            for (int i = 0; i < beehives.Count; i++)
            {
                if (hornets.Count == 0)
                {
                    leftBeehives.Add(beehives[i]);
                    continue;
                }
                if (hornetsPower <= beehives[i])
                {
                    var leftBeehive = beehives[i] - hornetsPower;
                    if (leftBeehive > 0)
                    {
                        leftBeehives.Add(leftBeehive);
                    }
                    hornets.RemoveAt(0);
                    hornetsPower = hornets.Sum();
                }
            }

            if (leftBeehives.Count > 0)
            {
                Console.WriteLine(string.Join(" ", leftBeehives));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }

        }
    }
}
