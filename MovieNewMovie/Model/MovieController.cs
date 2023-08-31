using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieNewMovie.Model
{
    internal class MovieController
    {
        MovieManager storage = new MovieManager();
        public void UploadMovie()
        {
            Console.Write("Enter the movie title: ");
            string movieName = Console.ReadLine();

            Console.Write("Enter the movie ID: ");
            int movieId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the movie year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the movie director: ");
            string director = Console.ReadLine();

            storage.UploadMovie(movieId, movieName, year, director);
            Console.WriteLine("Movie uploaded successfully.");
        }

        public void DisplayMovies()
        {
            string movieDetails = storage.DisplayMovies();

            if (string.IsNullOrEmpty(movieDetails))
            {
                Console.WriteLine("Storage is empty.");
            }
            else
            {
                Console.WriteLine("Movies in storage:");
                Console.WriteLine(movieDetails);
            }
        }

        public void Delete()
        {
            
            
            Console.Write("Enter the index of the movie to delete: ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;
            storage.DeleteMovie(index);
            Console.WriteLine("Movie deleted successfully.");
        }


        public void SearchMoviesByYear()
        {
            Console.Write("Enter the year to search for: ");
            if (int.TryParse(Console.ReadLine(), out int year))
            {
                List<Movie> searchResults = storage.SearchByYear(year);

                if (searchResults.Count == 0)
                {
                    Console.WriteLine("No movies found for the specified year.");
                }
                else
                {
                    Console.WriteLine($"Movies released in {year}:");
                    foreach (var movie in searchResults)
                    {
                        Console.WriteLine($"{movie.MovieName} (Directed by {movie.Director})");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid year. Please enter a valid year.");
            }
        }
        public void Start()
        {
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Upload Movie");
                Console.WriteLine("2. Display Movies");
                Console.WriteLine("3. Delete Movie");
                Console.WriteLine("4. search by year");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        UploadMovie();
                        break;

                    case 2:
                        DisplayMovies(); 
                        break;
                    case 3:

                        Delete();
                        break;
                    case 4:
                        SearchMoviesByYear();
                        break;
                    case 5:
                        Console.WriteLine("Exiting program.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }

        }
    }
}
