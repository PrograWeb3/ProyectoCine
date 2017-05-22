using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoCine.Models
{
    public class Movie
    {
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