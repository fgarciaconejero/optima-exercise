using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class ScoreBoard
    {
        // ScoreBoard properties
        public List<Match> Matches { get; private set; }

        // ScoreBoard properties
        public ScoreBoard() 
        {
            Matches = new List<Match>();
        }

        // ScoreBoard functions
        public void StartMatch(Match match)
        {
            Matches.Add(match);
        }
    }
}
