using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Exception1.Collection
{
    class Player
    {
        int PlayerId;
        string PlayerName,Country,team;

        public Player(int playerId, string playerName, string country, string team)
        {
            PlayerId1 = playerId;
            PlayerName1 = playerName;
            Country1 = country;
            this.Team = team;
        }

        public int PlayerId1 { get => PlayerId; set => PlayerId = value; }
        public string PlayerName1 { get => PlayerName; set => PlayerName = value; }
        public string Country1 { get => Country; set => Country = value; }
        public string Team { get => team; set => team = value; }
    }
    class Collection7
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(new Player(1, "Dhoni", "India", "CSk"));
            al.Add(new Player(2, "Virat", "India", "RCB"));
            al.Add(new Player(3, "Rohit", "India", "MI"));
            al.Add(new Player(4, "Maxwell", "Australia", "RCB"));
            al.Add(new Player(5, "Duplic", "Australia", "RCB"));
            al.Add(new Player(1, "Hardhik", "India", "GT"));
            al.Add(new Player(1, "Suriya", "India", "MI"));

            int maxc=0;
            string maxname = "";
            foreach (Player p in al)
            {
                string t = p.Team;
                int c = 0;
                foreach (Player p2 in al)
                {
                    if (p2.Team==t && p.Country1=="Australia")
                        c++;
                }
                if (c>maxc)
                {
                    maxname = p.Team;
                    maxc = c;
                }
            }
            Console.WriteLine("Maximum Player Australia"+maxname+" "+maxc);

        }
    }
}
