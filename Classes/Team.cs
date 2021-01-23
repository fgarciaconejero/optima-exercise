using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Team
    {
        // Team properties
        public string Name { get; }
        public int Score { get; set; }

        // Team constructor
        public Team(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }
}
