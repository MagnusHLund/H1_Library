using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Library.View
{
    internal class View
    {
        /// <summary>
        /// Outputs a custom message, based on the string parameter
        /// </summary>
        /// <param name="message"></param>
        public void Message(string message)
        {
            Console.WriteLine(message);
        }

        /// <summary>
        /// Outputs a message based on the parameter.
        /// The color will be green for the outputted text and it will reset back to white.
        /// </summary>
        /// <param name="message"></param>
        public void GreenMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        /// <summary>
        /// Reads the user input, using a console.readline, which gets returned to wherever it was called
        /// </summary>
        /// <returns></returns>
        public string RL()
        {
            return Console.ReadLine();
        }

        /// <summary>
        /// Clears the console window
        /// </summary>
        public void clear()
        {
            Console.Clear();
        }
    }
}
