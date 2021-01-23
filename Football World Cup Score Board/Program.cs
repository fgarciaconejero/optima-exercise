using Classes;
using System;
using System.Collections.Generic;

namespace Football_World_Cup_Score_Board
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int input = 0;
            //    List<Match> matches = new List<Match>();

            //    Console.WriteLine("Welcome to the Football World Cup Score Board!");
            //    while (input != 9)
            //    {
            //        Menu();
            //        input = EnterIntegerToConsole(false);

            //        Console.Clear();
            //        switch (input)
            //        {
            //            case 1:
            //                Console.WriteLine("Please enter the first team's name.");
            //                string firstTeamName = Console.ReadLine();
            //                Console.WriteLine("Please enter the first team's score.");
            //                int firstTeamScore = EnterIntegerToConsole(false);
            //                Console.WriteLine("Please enter the second team's name.");
            //                string secondTeamName = Console.ReadLine();
            //                Console.WriteLine("Please enter the second team's score.");
            //                int secondTeamScore = EnterIntegerToConsole(false);
            //                Match auxMatch = new Match();
            //                Team firstTeam = new Team(firstTeamName, firstTeamScore);
            //                Team secondTeam = new Team(secondTeamName, secondTeamScore);

            //                auxMatch.StartMatch(firstTeam, secondTeam);
            //                matches.Add(auxMatch);
            //                break;

            //        }

            //    }
            //    Console.WriteLine("Thanks for using Football World Cup Score Board.");
            //    Console.WriteLine("Exiting...");
        }

        private static int EnterIntegerToConsole(bool format)
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

        static void Menu()
        {
            Console.WriteLine("Please type one of the following values:");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine(" 1 - Start new match.\n");
            Console.WriteLine(" 9 - Exit program.\n");
            Console.WriteLine("------------------------------------------------------------------------ \n");
        }
    }
}
