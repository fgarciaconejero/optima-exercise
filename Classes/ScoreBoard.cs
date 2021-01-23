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
        private void StartMatch(Match match)
        {
            Matches.Add(match);
        }

        public void ProcessInput(int input)
        {
            switch (input)
            {
                case 1:
                    Console.WriteLine("Please enter the first team's name.");
                    string firstTeamName = Console.ReadLine();
                    Console.WriteLine("Please enter the first team's score.");
                    int firstTeamScore = EnterIntegerToConsole(false);

                    Console.WriteLine("Please enter the second team's name.");
                    string secondTeamName = Console.ReadLine();
                    Console.WriteLine("Please enter the second team's score.");
                    int secondTeamScore = EnterIntegerToConsole(false);

                    Team firstTeam = new Team(firstTeamName, firstTeamScore);
                    Team secondTeam = new Team(secondTeamName, secondTeamScore);
                    Match auxMatch = new Match(firstTeam, secondTeam);

                    StartMatch(auxMatch);
                    break;
            }
        }

        public static int EnterIntegerToConsole(bool format)
        {
            int input = 0;
            while (format == false)
            {
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                    format = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nWrong input type! Please, enter an integer.");
                }
            }
            return input;
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Please type one of the following values:");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine(" 1 - Start new match.\n");
            Console.WriteLine(" 9 - Exit program.\n");
            Console.WriteLine("------------------------------------------------------------------------ \n");
        }
    }
}
