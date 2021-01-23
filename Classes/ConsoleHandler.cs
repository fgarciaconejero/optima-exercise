using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class ConsoleHandler:IConsoleHandler
    {
        public string ReadString()
        {
            return Console.ReadLine();
        }
        public int ReadInt(bool format)
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
