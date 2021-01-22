using System;

namespace Classes
{
    public class Match
    {
        public Team HomeTeam { get; }
        public Team AwayTeam { get; }

        public Match(Team homeTeam, Team awayTeam)
        {
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
        }
    }
}
