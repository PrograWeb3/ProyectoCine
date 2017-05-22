using ProyectoCine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProyectoCine.Controllers.Api
{
    public class MoviesController : ApiController
    {
        //public static List<Movie> movies = new List<Movie>
        //    {
        //        new Movie
        //        {
        //            Id = 1,
        //            Title = "The Lord of the Rings",
        //            Description = "Peli con elfos, hobbits, ogros y dementores. Basada en hechos reales de la Edad Media.",
        //            Clasification = "PG-13",
        //            Genre = "Fantasía",
        //            Duration = "15:10"
        //        },
        //        new Movie
        //        {
        //            Id = 2,
        //            Title = "Los Vengadores",
        //            Description = "Grupete en calzas que salva al mundo de bichos de otras dimensiones. Basada en el comics de Marvel",
        //            Clasification = "PG-13",
        //            Genre = "Superheroes",
        //            Duration = "02:54"
        //        },
        //        new Movie
        //        {
        //            Id = 3,
        //            Title = "Batman",
        //            Description = "Hombre que se cree un murciélago. Basada en los comics de DC",
        //            Clasification = "PG-18",
        //            Genre = "Superheroes",
        //            Duration = "02:24"
        //        }
        //    };

        public MoviesController()
        {
            
        }

        // GET /api/movies
        public IEnumerable<Movie> GetMovies(string query = null)
        {
            
            // if (!String.IsNullOrWhiteSpace(query))
            
            return Movie.movies.ToList();
            
            //.Select(Mapper.Map<Movie, MovieDto>);
        }

        [HttpDelete]
        public IHttpActionResult DeleteMovie(int id)
        {
            var itemToRemove = Movie.movies.Single(movie => movie.Id == id);
            Movie.movies.Remove(itemToRemove);

            return Ok();
        }
    }
}
