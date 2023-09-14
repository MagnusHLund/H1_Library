using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Library.Model
{
    /// <summary>
    /// This class just contains a list with a bunch of predefined values for books
    /// </summary>
    internal class Library
    {
        // List of 23 books
        public List<Book> books = new List<Book>()
        {
            new Book()
            {
                Title = "Kris the thief: Nerf gun",
                Description = "the 3266th installment of the 'Kris the thief'.\nFinally Kris has the opportunity to accomplish his master plan.\nKris had been planning on stealing from his grandson, ever since he was 6.\nHe has now gotten a family and a grandson and decided to take what he liked most. His nerf gun.",
                Genre = "History, Biography, True crime",
                Release = "12/06/2021"
            },
            new Book()
            {
                Title = "Mikkels guide to a healthy body",
                Description = "Mikkel recently underwent a massive body change, which has caused him to write this book, to help others.",
                Genre = "Self-help, Cookbook, Biography",
                Release = "14/09/2023"
            },
            new Book()
            {
                Title = "Mikkels guide to save money",
                Description = "Mikkel always had issues with money... \nTHEREFORE HE STARTED HIS OWN BANK! How does he save money now? child labor.",
                Genre = "self-help, Biography",
                Release = "11/08/2023"
            },
            new Book()
            {
                Title = "The rise of Krølls bank",
                Description = "Mikkel talks about how his bank changed the industry and will stay around for generations, due to his new technique.",
                Genre = "Biography", 
                Release = "28/08/2023"
            },
            new Book()
            {
                Title = "The downfall of Krølls bank",
                Description = "Krølls bank failed. Used child labor. Got boycotted.",
                Genre = "Documentary",
                Release = "29/08/2023"
            },
            new Book()
            {
                Title = "The vodka king",
                Description = "The vodka king is a story about a Russian superhero. He likes vodka.",
                Genre = "History, Horror", 
                Release = "29/05/1996"
            },
            new Book()
            {
                Title = "Kris and the struct",
                Description = "Kris talks about how he never sees structs in C#, however our team discovered that he saw 17 C# projects using structs, the 13th September 2023. BUSTED!",
                Genre = "Documentary",
                Release = "14/09/2023"
            },
            new Book()
            {
                Title = "Camilla on the front end",
                Description = "Camilla goes through tips and trick, for website front end development.",
                Genre = "Self-help", 
                Release = "19/12/2022"
            },
            new Book()
            {
                Title = "Mikkel the data manipulator",
                Description = "Mikkel takes down a country, by changing a 1 to a 0.",
                Genre = "Adventure, Comedy",
                Release = "01/01/1753"
            },
            new Book()
            {
                Title = "The typo returns",
                Description = "Thsi boks is al abotu how to aviod riting typos. It gos through diffrent techneques to becom beter at wriitng.",
                Genre = "Slfe-hepl, Cumedi",
                Release = "91/13/2032"
            },
            new Book()
            {
                Title = "Mikkel's Marvelous Misadventures in Debugging",
                Description = "Mikkel found a mysterious computer with visual studio open.\nThe project is full of errors, however mikkel is determined to fix them.",
                Genre = "Adventure, Science fiction", 
                Release = "11/09/2001"
            },
            new Book()
            {
                Title = "The next generation",
                Description = "The year is 2069 and Kris' grandchild is programming a giant nerf gun turret to automatically shoot his grandfather.\nThe turret is designed to shoot moving targets, however Kris is on life support and doesn't move much.",
                Genre = "Fantasy", 
                Release = "04/05/2021"
            },
            new Book()
            {
                Title = "The next generatione: Ctrl + Z (THE PREQUEL)",
                Description = "Kris introduces his grandchild the wonders of programming, which surely wont come back to haunt him in the future.",
                Genre = "Fantasy",
                Release = "06/04/2022"
            },
            new Book()
            {
                Title = "Camilla the code whispherer",
                Description = "Camilla plays with the Chat-GPT API, adds TTS to her program and talks to her computer to create code.",
                Genre = "Essay", 
                Release = "21/05/2023"
            },
            new Book()
            {
                Title = "Keyboard shortcuts with Kris",
                Description = "Kris goes through his top 100 keyboard shortcuts.",
                Genre = "Self-help, Comedy",
                Release = "03/05/2019"
            },
            new Book()
            {
                Title = "The tale of Mikkel the body builder",
                Description = "Mikkel took steriods and it came back to haunt him. Mikkel talks about his biggest regrets.",
                Genre = "Biography", 
                Release = "20/09/2023"
            },
            new Book()
            {
                Title = "Brain.TimeoutException",
                Description = "Book written by robots about how dumb humans are. Best seller.",
                Genre = "Science",
                Release = "06/06/2026"
            },
            new Book()
            {
               Title = "Brain.NullReferenceException",
                Description = "The much anticipated sequel, in the 'brain.' series. This book takes a step further than the previous installment, in talking about human stupidity. Written by robots.",
                Genre = "Science",
                Release = "07/06/2026"
            },
            new Book()
            {
                Title = "The Doctor and the InvalidOperationException",
                Description = "The year is 4200. Doctors use robots for everything and they dont even need an education to become a doctor.\nAll of the sudden all the robot doctors break down and the human doctors have to do the surgeries and operations",
                Genre = "Science fiction", 
                Release = "04/07/2024"
            },
            new Book()
            {
                Title = "Mikkel and the SqlException",
                Description = "Mikkel had gone his entire life without doing any mistakes, until his luck turned around",
                Genre = "Comedy",
                Release = "09/02/2024"
            },
            new Book()
            {
                Title = "Harry potter and the Sorcerers code",
                Description = "Harry Potter is trying to become the worlds most famous programmer. However nobody can be good at everything, and Potter decided to specialize in installation wizards.",
                Genre = "Adventure", 
                Release = "26/06/1997"
            },
            new Book()
            {
                Title = "Star wars and the Revenge of the Exception",
                Description = "After many years of hiding in plain sight, the exceptions finally get their chance to take over the galaxy.",
                Genre = "Science fiction, fantasy",
                Release = "19/05/2005"
            },
            new Book()
            {
                Title = "Indiana Jones and the lost debugger",
                Description = "Indiana jones has discovered an ancient IDE which has no debugging tools, in a temple.\nTo progress in the temple he has to fix the 500.000 lines code.\nHe cant install a new IDE because the computer only has a floppy disk which cant contain modern IDE's\nWill he succeed?",
                Genre = "Comedy", 
                Release = "15/01/2015"
            }
        };
    }
}
