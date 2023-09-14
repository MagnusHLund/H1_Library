using H1_Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Library.Controller
{
    internal class Controller
    {
        // Stack which contains all the books that the user wants to loan
        Stack<Book> loan = new();

        View.View view = new();

        /// <summary>
        /// The start method repeats the whole library loan system, using a while loop.
        /// First it calls the TakeBooks method, which lets the user pick their books, then it allows them to loan the books by calling the Loan method.
        /// Afterwards it prompts the user to press enter to start over.
        /// </summary>
        public void Start()
        {
            while (true)
            {
                TakeBooks();
                Loan();

                view.GreenMessage("Press enter to start over");
                view.RL();
                view.clear();
            }
        }

        /// <summary>
        /// TakeBooks lets the user pick any book inside the library.
        /// First the program outputs all the books in the console, which the user can scroll through and find what they want to loan.
        /// The user is then prompted to write the names of the books they wanna loan.
        /// Once they are done collecting books, the user can press enter and then the program breaks out of the while loop.
        /// </summary>
        void TakeBooks()
        {
            // Library list containing all the library books
            Library library = new();

            /// Outputs each book in the library
            foreach (Book book in library.books)
            {
                view.Message(book.Title);
                view.Message(book.Description);
                view.Message(book.Genre);
                view.Message($"{book.Release}\n");
            }

            view.GreenMessage("\nWhich books do you wanna loan? input empty string when done.\n");

            // Infinite loop which lets user pick one of each book in the library.
            // Once the user inputs an empty line, the while loop will break, and the program moves onto the next method.
            while (true)
            {
                string input = view.RL().ToLower();

                if (input == "")
                {
                    break;
                }
                else
                {
                    // Checks each book if they contain the input that the user gave, if it does the the stack gets the book and the library loses it.  
                    foreach (Book book in library.books)
                    {
                        if (book.Title.ToLower().Contains(input))
                        {
                            loan.Push(book);
                            library.books.Remove(book);

                            break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Outputs each book that the user is loaning and deletes it from the stack.
        /// </summary>
        void Loan()
        {

            view.GreenMessage("\nScanning the books, to loan them");

            while (loan.Count > 0)
            {
                view.Message(loan.Peek().Title);
                loan.Pop();
            }
        }
    }
}
