using eBilety.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eBilety.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Nazwa")]
        public string Name { get; set; }
        [Display(Name = "Opis")]
        public string Description { get; set; }
        public double Price { get; set; }
        [Display(Name = "Obrazek")]
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //Zaleznosci

        public List<Actor_Movie> Actors_Movies { get; set; }

        //Cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
    }
}
