using System;

namespace Classes
{
    public class Match
    {
        public Team HomeTeam { get; private set; }
        public Team AwayTeam { get; private set; }

        public Match() { }
        public Match(Team homeTeam, Team awayTeam)
        {
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
        }
        public void StartMatch(Team homeTeam, Team awayTeam)
        {
            this.HomeTeam = homeTeam;
            this.AwayTeam = awayTeam;
        }
    }
}
