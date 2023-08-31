using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieNewMovie.Model
{
    internal class MovieManager
    {

        private List<Movie> movies = new List<Movie>();

        public void UploadMovie(int movieId, string movieName, int year, string director)
        {
            movies.Add(new Movie(movieId, movieName, year, director));
            
        }

        public string DisplayMovies()
        {
            string movieDetails = "";

            foreach (var movie in movies)
            {
                movieDetails += $"Title: {movie.MovieName}\n";
                movieDetails += $"Director: {movie.Director}\n";
                movieDetails += $"Release Year: {movie.Year}\n";
                movieDetails += "\n";
            }

            return movieDetails;
        }



        public void  DeleteMovie(int index)
        {
            if (index >= 0 && index < movies.Count)
            {
                movies.RemoveAt(index);
                //movies.RemoveAt(index);

            }
        }
        public List<Movie> SearchByYear(int year)
        {
            List<Movie> result = movies.Where(movie => movie.Year == year).ToList();
            return result;
        }

    }
}

