using System;
using System.Collections.Generic;
using System.Text;

namespace MockBuster
{

    //***Derived from User class and has same filtering as User but can add, update and delete movies from repo
    class Admin : User
    {
        List<Movie> movieList = new List<Movie>();

        //    ***A method to add a movie to the repo
        public static void AddMovie()
        {
            List<Movie> movieList = new List<Movie>();
           
            Console.WriteLine("Please enter the name of the movie:");
            movieList[0].MovieName = Console.ReadLine();

            Console.WriteLine("Please enter the main actor:");
            movieList[0].MainActor = Console.ReadLine();

            Console.WriteLine("Please enter the genre:");
            movieList[0].Genre = Console.ReadLine();

            Console.WriteLine("Please enter the name of the director:");
            movieList[0].Director = Console.ReadLine();

           Console.WriteLine("Thank you!" + movieList[0].MovieName + " has been added to the movie list!");

        }


        //    ***A method to choose a movie from the repo to delete
        //Print a list of movies and delete at the index & inform user if the movie was removed successfully
        public static void RemoveMovie()
        {
            List<Movie> movieList = new List<Movie>();

            //Print List of movies and index and delete at that index 
            Console.WriteLine("What movie would you like to remove?");
            //remove movie from list
            Console.WriteLine("That movie has been removed.");

        }

        //    ***A method to choose a movie from the repo to update
        //Print a list of movies and choose one and update/edit the name, genre, main actor or director
        public static void UpdateMovie()
        {
            List<Movie> movieList = new List<Movie>();

            // Print List of movies at index and update at that index
            Console.WriteLine("What movie would you like to update?");
            //update movie from list
            Console.WriteLine("That movie has been updated");

        }


















        //    ***A method that adds a movie object to the repo
        //Console.WriteLine("Please enter the style to add:");
        //string style = Console.ReadLine();
        //Console.WriteLine("Please enter the number of sizes available:");
        //int numberOfSizes = int.Parse(Console.ReadLine());
        //List<int> sizes = new List<int>();
        //for(int i = 0; i<numberOfSizes; i++)
        //{
        //    Console.Write("Size " + (i + 1) + ":");
        //    sizes.Add(int.Parse(Console.ReadLine()));
        //}
        //pants.Add(new Pants(style, sizes));
        //Console.WriteLine("Thank you - " + style + " have been added in " + numberOfSizes + " sizes!");



        //ANOTHER WAY TO ADD 
        //   for (int i = 0; i<Movies.Count; i++)
        //        {
        //            Movie m = Movies[i];

        //            //Check if the category matches
        //            if (m.Category == category)
        //            {
        //                output.Add(m);
        // }
        //}







        //    ***A method to remove a movie from the repo
        //    Inform the user if the movie was successfully removed or if it doesn't exist
        //     Console.WriteLine("Please enter the style to delete:");
        //               string style = Console.ReadLine();
        //               for(int i = 0; i<pants.Count; i++)
        //{
        //                   if(pants[i].GetStyle() == style)
        //	{
        //                       pants.Remove(pants[i]);
        //	}
        //}


    }
}



//public static Student SearchStudentsByName(List<Student> students, string name)
//{
//    for (int i = 0; i < students.Count; i++)
//    {
//        Student s = students[i];
//        if (s.Name.ToLower() == name.ToLower())
//        {
//            return s;
//        }
//    }