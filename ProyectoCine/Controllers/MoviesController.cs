using ProyectoCine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoCine.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            //var movies = new List<Movie>
            //{
            //    new Movie
            //    {
            //        Title = "The Lord of the Rings",
            //        Description = "Peli con elfos, hobbits, ogros y dementores. Basada en hechos reales de la Edad Media.",
            //        Clasification = "PG-13",
            //        Genre = "Fantasía",
            //        Duration = "15:10"
            //    },
            //    new Movie
            //    {
            //        Title = "Los Vengadores",
            //        Description = "Grupete en calzas que salva al mundo de bichos de otras dimensiones. Basada en el comics de Marvel",
            //        Clasification = "PG-13",
            //        Genre = "Superheroes",
            //        Duration = "02:54"
            //    },
            //    new Movie
            //    {
            //        Title = "Batman",
            //        Description = "Hombre que se cree un murciélago. Basada en los comics de DC",
            //        Clasification = "PG-18",
            //        Genre = "Superheroes",
            //        Duration = "02:24"
            //    }
            //};
            //return View(movies);
            return View();
        }


    }
}