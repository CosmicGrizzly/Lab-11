using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program

    {
        static void Main(string[] args)
        {
            string userInput;
            string response = "y";
            List<Movie> filmList = new List<Movie>();
            filmList.Add(new Movie("BladeRunner", "Scifi"));
            filmList.Add(new Movie("The Princess Bride", "Drama"));
            filmList.Add(new Movie("Princess Mononoke", "Animated"));
            filmList.Add(new Movie("Sphere", "Horror"));
            filmList.Add(new Movie("The boy and the beast", "Animated"));
            filmList.Add(new Movie("It", "Horror"));
            filmList.Add(new Movie("Tron", "Scifi"));
            filmList.Add(new Movie("The Never Ending Story", "Drama"));
            filmList.Add(new Movie("Your Name", "Animated"));
            filmList.Add(new Movie("Grave of the Fireflies", "Animated"));

            Console.WriteLine("Welcome to the Movie List Application!");

            while (response == "y")
            {

                Console.WriteLine("There are 10 movies in this list!");
                Console.WriteLine(string.Format("{0,15}{1,15}{2,15}{3,15}", "Animated", "Drama", "Horror", "Scifi"));

                Console.Write("What category are you interested in? ");
                userInput = Console.ReadLine();

                foreach (Movie m in filmList)
                {
                    if (userInput.ToLower() == m.Category.ToLower())
                    {
                        Console.WriteLine(m.Title);
                    }
                }
                Console.WriteLine("Would you like to continue? (y/n) ");
                response = Console.ReadLine();
                
            }
            Console.WriteLine("Thanks for looking at the Movie List app!");
            Console.WriteLine("Now! Lets all go to the Lobby, and get ourselves a Snack!");
        }
    }
}
