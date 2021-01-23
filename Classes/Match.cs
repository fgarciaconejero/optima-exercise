using System;

namespace Classes
{
    public class Match
    {
        // Match properties
        public Team HomeTeam { get; private set; }
        public Team AwayTeam { get; private set; }

        // Match constructor
        public Match() { }

        // Match functions
        public void StartMatch(Team homeTeam, Team awayTeam)
        {
            this.HomeTeam = homeTeam;
            this.AwayTeam = awayTeam;
        }
    }
}
