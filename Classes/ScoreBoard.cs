using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class ScoreBoard
    {
        // ScoreBoard properties
        public List<Match> Matches { get; private set; }
        public IConsoleHandler consoleHandler;

        // ScoreBoard properties
        public ScoreBoard(IConsoleHandler consoleHandler) 
        {
            Matches = new List<Match>();
            this.consoleHandler = consoleHandler;
        }

        // ScoreBoard functions
        public void StartMatch(Match match)
        {
            Matches.Add(match);
        }

        public void ProcessInput(int input)
        {
            switch (input)
            {
                case 1:
                    Console.WriteLine("Please enter the first team's name.");
                    string firstTeamName = consoleHandler.ReadString();
                    Console.WriteLine("Please enter the first team's score.");
                    int firstTeamScore = consoleHandler.ReadInt(false);

                    Console.WriteLine("Please enter the second team's name.");
                    string secondTeamName = consoleHandler.ReadString();
                    Console.WriteLine("Please enter the second team's score.");
                    int secondTeamScore = consoleHandler.ReadInt(false);

                    Team firstTeam = new Team(firstTeamName, firstTeamScore);
                    Team secondTeam = new Team(secondTeamName, secondTeamScore);
                    Match auxMatch = new Match(firstTeam, secondTeam);

                    StartMatch(auxMatch);
                    break;
                case 2:
                    Console.WriteLine(GetSummary());
                    Console.WriteLine("Press any button to go back to the menu.");
                    Console.Read();
                    Console.Clear();
                    break;
            }
        }

        public string GetSummary()
        {
            string result = "";
            for (int i = 0; i < Matches.Count; i++)
            {
                result += "Match ID: " + (i+1) + " - " + Matches[i].HomeTeam.Name + " " + Matches[i].HomeTeam.Score + " vs " + Matches[i].AwayTeam.Name + " " + Matches[i].AwayTeam.Score + "\n";
            }
            return result;
        }

        public void FinishMatch(int id)
        {
            Matches.Remove(Matches[id]);
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Please type one of the following values:");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine(" 1 - Start new match.\n");
            Console.WriteLine(" 2 - Get a summary of the matches in the score board.\n");
            Console.WriteLine(" 9 - Exit program.\n");
            Console.WriteLine("------------------------------------------------------------------------ \n");
        }
    }
}
