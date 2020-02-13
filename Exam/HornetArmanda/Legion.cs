using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetArmanda
{
    public class Legion
    {
        public Dictionary<int, string> LastActivityLegionName { get; set; }

        public string LegionName { get; set; }

        public string SoldierType { get; set; }

        public int SoldierCount { get; set; }
    }
}
