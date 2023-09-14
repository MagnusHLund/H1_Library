using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Library.View
{
    internal class View
    {
        public void Message(string message)
        {
            Console.WriteLine(message);
        }

        public void GreenMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public string RL()
        {
            return Console.ReadLine();
        }

        public void clear()
        {
            Console.Clear();
        }
    }
}
