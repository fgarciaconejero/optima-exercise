using Classes;
using System;
using System.Collections.Generic;

namespace Football_World_Cup_Score_Board
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            ConsoleHandler consoleHandler = new ConsoleHandler();
            ScoreBoard scoreBoard = new ScoreBoard(consoleHandler);

            Console.WriteLine("Welcome to the Football World Cup Score Board!");
            while (input != 9)
            {
                scoreBoard.DisplayMenu();
                input = consoleHandler.ReadInt(false);

                Console.Clear();
                scoreBoard.ProcessInput(input);
            }
            Console.WriteLine("Thanks for using Football World Cup Score Board.");
            Console.WriteLine("Exiting...");
        }
    }
}
