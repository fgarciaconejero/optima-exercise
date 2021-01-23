using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    public class ScoreBoard
    {
        // ScoreBoard properties
        public List<Match> Matches { get; private set; }
        public IConsoleHandler consoleHandler;

        // ScoreBoard constructor
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
                    Match auxMatch = new Match(firstTeam, secondTeam, Matches.Count);

                    StartMatch(auxMatch);
                    break;
                case 2:
                    Console.WriteLine(GetSummary());
                    Console.WriteLine("Press ENTER to go back to the menu.");
                    Console.Read();
                    Console.Clear();
                    break;
                case 3:
                    Console.WriteLine("Choose the match you wish to update by týping its ID.");
                    Console.WriteLine(GetSummary());
                    int id = consoleHandler.ReadInt(false);
                    Console.Clear();

                    Console.WriteLine("Enter the updated score of the home team.");
                    int homeTeamScore = consoleHandler.ReadInt(false);
                    Console.Clear();

                    Console.WriteLine("Enter the updated score of the away team.");
                    int awayTeamScore = consoleHandler.ReadInt(false);
                    Console.Clear();

                    UpdateScore(id, homeTeamScore, awayTeamScore);
                    break;
                case 4:
                    Console.WriteLine("Choose the match you wish to finish by týping its ID.");
                    Console.WriteLine(GetSummary());
                    FinishMatch(consoleHandler.ReadInt(false));
                    break;
                case 9:
                    break;
                default:
                    Console.WriteLine("Please enter a valid value.");
                    break;
            }
        }

        public void UpdateScore(int id, int homeScore, int awayScore)
        {
            Matches[id].HomeTeam.Score = homeScore;
            Matches[id].AwayTeam.Score = awayScore;
        }

        public string GetSummary()
        {
            string result = "";
            List<Match> sortedMatches = Matches.OrderByDescending(o => (o.HomeTeam.Score + o.AwayTeam.Score)).ThenByDescending(o => o.ID).ToList<Match>();
            for (int i = 0; i < Matches.Count; i++)
            {
                result += "Match ID: " + sortedMatches[i].ID + " - " + sortedMatches[i].HomeTeam.Name + " " + sortedMatches[i].HomeTeam.Score + " vs " + sortedMatches[i].AwayTeam.Name + " " + sortedMatches[i].AwayTeam.Score + "\n";
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
            Console.WriteLine(" 3 - Update a match's score.\n");
            Console.WriteLine(" 4 - Finish a match.\n");
            Console.WriteLine(" 9 - Exit program.\n");
            Console.WriteLine("------------------------------------------------------------------------ \n");
        }
    }
}
