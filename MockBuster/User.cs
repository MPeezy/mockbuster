using System;
using System.Collections.Generic;
using System.Text;

namespace MockBuster
{
    public class User
    {
        List<Movie> movieList = new List<Movie>();

        //***Base class*** Can view list of movies and filter with the specific properties



        //    ****A method to filter by genre and returns list of movies only in that genre***
        //Enter movie genre and print index for that movie
        public static void PrintListByGenre()
        {
            Console.WriteLine("What genre are you looking for? Please enter drama, romantic comedy, action, animated or science fiction: ");
        }


        //    ***A method to filter by movie name and returns a list of only those movie names***
        //Enter movie name and print index for that movie
        public static void PrintListByMovieName()
        {
            Console.WriteLine("Enter the name of the movie you are looking for:");

        }

        //    ***A method to filter by Main actors and returns a list of movies of only those main actors***
        //Enter movie main actor and print index for that movie
        public static void PrintListByMainActor()
        {
            Console.WriteLine("Enter the name of the actor are you looking for: ");
        }

        //    ***A method to filter by director and returns a list of movies with only those directors***
        //Enter movie director and print index for that movie
        public static void PrintListByDirector()
        {
            Console.WriteLine("Enter the name of the director you are looking for: ");
        }
    }
}

////we want to print the name and index of our student
//public static void PrintList(List<Student> students)
//{
//    for (int i = 0; i < students.Count; i++)
//    {
//        //we want to print the name and index of our student
//        Student s = students[i];
//        Console.WriteLine($"{i}: {s.Name}");

//        //This is valid as well
//        //Console.WriteLine($"{i}: {students[i].Name}");
//    }
//}