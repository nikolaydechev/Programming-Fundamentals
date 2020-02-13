using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.TeamworkProjects
{
    public class Team
    {
        public Team(string creator, string teamname, List<string> members)
        {
            this.CreatorName = creator;
            this.TeamName = teamname;
            this.Members = members;
        }

        public string CreatorName { get; set; }

        public string TeamName { get; set; }

        public List<string> Members { get; set; }
    }
}
