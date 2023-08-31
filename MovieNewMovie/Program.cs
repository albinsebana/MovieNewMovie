using MovieNewMovie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieNewMovie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            MovieController movieController = new MovieController();

            movieController.Start();
        }
    }
}