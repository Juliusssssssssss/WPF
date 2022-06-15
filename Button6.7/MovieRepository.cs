using System;
using System.Collections.Generic;

namespace Button6._7
{

    class MovieRepository
    {
        List<Movie> movies = new List<Movie>
            {
                new Movie
                {
                    Id = 1,
                    Titel = "Star Trek: Beyond",
                    RD = new DateTime(2016, 07, 22),
                    Director = "Justin Lin",
                    IC = true,
                    Format = "2.35:1",
                    Genre = "Sci-Fi"
                },
                new Movie
                {
                    Id = 1,
                    Titel = "Star Wars: The Last Jedi",
                    RD = new DateTime(2017, 12, 15),
                    Director = "Ryan Johnson",
                    IC = true,
                    Format = "2.39:1",
                    Genre = "Epic Space Opera"
                }
            };
        public List<Movie> GetAll()
        {
            return movies;
        }
        public void AddNew(Movie movie)
        {
            movies.Add(movie);
        }
        public void Update(Movie movieToUpdate)
        {
            foreach (Movie movie in movies)
            {
                if (movie.Id == movieToUpdate.Id)
                {
                    movies.Remove(movie);
                    movies.Add(movieToUpdate);
                    break;
                }
            }
        }
    }


}
