using System;

namespace Classes
{
    public class Match
    {
        // Match properties
        public Team HomeTeam { get; private set; }
        public Team AwayTeam { get; private set; }
        public int ID { get; private set; }

        // Match constructor
        public Match(Team homeTeam, Team awayTeam, int ID)
        {
            this.HomeTeam = homeTeam;
            this.AwayTeam = awayTeam;
            this.ID = ID;
        }
    }
}
