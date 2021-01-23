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
            ScoreBoard scoreBoard = new ScoreBoard(new ConsoleHandler());

            Console.WriteLine("Welcome to the Football World Cup Score Board!");
            while (input != 9)
            {
                scoreBoard.DisplayMenu();
                input = EnterIntegerToConsole(false);

                Console.Clear();
                scoreBoard.ProcessInput(input);
            }
            Console.WriteLine("Thanks for using Football World Cup Score Board.");
            Console.WriteLine("Exiting...");
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
    }
}
