using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Library.Model
{
    /// <summary>
    /// This class is an object for a book. It has 4 properies. Title, description, release, genre.
    /// </summary>
    internal class Book
    {
        private string _title;
        private string _description;
        private string _release;
        private string _genre;

        public string Title
        {
            get { return _title;  }
            set { _title = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string Release
        {
            get { return _release; }
            set { _release = value; }
        }

        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }
    }
}
