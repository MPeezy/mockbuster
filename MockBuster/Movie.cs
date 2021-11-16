using System;
using System.Collections.Generic;
using System.Text;

namespace MockBuster
{
    class Movie
    {
        public string MovieName { get; set; }
        public string MainActor { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }


        public Movie(string movieName, string mainActor, string genre, string director)
        {
            MovieName = movieName;
            MainActor = mainActor;
            Genre = genre;
            Director = director;
        }



        //override to string method to print movie name, main actor, genre, director
        public override string ToString()
        {
            string output = $"Movie Name: {MovieName} \n";
            output += $"Main Actor: {MainActor} \n";
            output += $"Genre: {Genre} \n";
            output += $"Director: {Director}";

            return output;
        }
  

    }
}
