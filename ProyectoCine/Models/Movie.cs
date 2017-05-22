using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoCine.Models
{
    public class Movie
    {
        public static List<Movie> movies = new List<Movie>
        {
            new Movie
            {
                Id = 1,
                Title = "The Lord of the Rings",
                Description = "Peli con elfos, hobbits, ogros y dementores. Basada en hechos reales de la Edad Media.",
                Clasification = "PG-13",
                Genre = "Fantasía",
                Duration = "15:10"
            },
            new Movie
            {
                Id = 2,
                Title = "Los Vengadores",
                Description = "Grupete en calzas que salva al mundo de bichos de otras dimensiones. Basada en el comics de Marvel",
                Clasification = "PG-13",
                Genre = "Superheroes",
                Duration = "02:54"
            },
            new Movie
            {
                Id = 3,
                Title = "Batman",
                Description = "Hombre que se cree un murciélago. Basada en los comics de DC",
                Clasification = "PG-18",
                Genre = "Superheroes",
                Duration = "02:24"
            }
        };

        public int Id { get; set; }

        [Required]
        [StringLength(256)]
        [Display(Name = "Título")]
        public string Title { get; set; }

        [Required]
        [StringLength(512)]
        [Display(Name = "Descripción")]
        public string Description { get; set; }

        // Campo de texto. En form un dropdown levanta todos los valores únicos usados hasta el momento.
        [Required]
        [StringLength(256)]
        [Display(Name = "Calificación")]
        public string Clasification { get; set; }

        // Campo de texto. En form un dropdown levanta todos los valores únicos usados hasta el momento.
        [Required]
        [StringLength(256)]
        [Display(Name = "Género")]
        public string Genre { get; set; }

        // ??? Ruta o URL
        [Required]
        public string Image { get; set; }

        // String con formato HH:MM.
        [Required]
        [Display(Name = "Duración")]
        [RegularExpression(@"^\d{2}\:[0-5]\d$", ErrorMessage = "El formato de duración ingresado es inválido")]
        public string Duration { get; set; }



        // Probando alternativa al string Duration
        private int minuteDuration;

        public string MinuteDuration
        {
            get
            {
                // convertir a int??
                var span = TimeSpan.FromMinutes(this.minuteDuration);
                return span.ToString(@"hh\:mm\:ss");
            }
            set
            {
                TimeSpan span = TimeSpan.Parse(value);
                this.minuteDuration = (int)span.TotalMinutes;
            }
        }
        
    }
}