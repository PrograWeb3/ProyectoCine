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
            
            return View();
        }
        
        [ActionName("agregar")]
        public ViewResult New()
        {
            // tomar generos y calificaciones
            return View("New", new Movie());
        }

    }
}