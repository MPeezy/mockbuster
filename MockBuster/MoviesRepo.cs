using System;
using System.Collections.Generic;
using System.Text;

namespace MockBuster
{
    class MoviesRepo
    {
   
        public static List<Movie> GetMovies()
        {
            List<Movie> movieList = new List<Movie>
            {
                new Movie("Forrest Gump", "Tom Hanks", "Drama","Robert Zemeckis"),
                new Movie("Pretty Woman", "Julia Roberts", "Romantic Comedy", "Gary Marshall "),
                new Movie("Aladdin", "Robin Williams", "Animated", "Ron Clements"),
                new Movie("Men In Black", "Will Smith", "Action", "Barry Sonnenfeld"),
                new Movie("Total Recall", "Arnold Schwarzenegger", "Science Fiction", "Paul Verhoeven"),
          
            };

            return movieList;
        }





    }
}


// public List<Movie> Movie { get; set; } = new List<Movie>();