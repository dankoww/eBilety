using eBilety.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eBilety.Models
{
    public class Actor:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Zdjęcie")]
        [Required(ErrorMessage = "Zdjęcie jest wymagane")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Imię i nazwisko")]
        [Required(ErrorMessage = "Imię i nazwisko jest wymagane")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Imię i nazwisko muszą zawierać od 3 do 50 znaków")]
        public string FullName { get; set; }
        [Display(Name = "O aktorze")]
        [Required(ErrorMessage = "Pole 'O aktorze' jest wymagane")]
        public string Bio { get; set; }

        //Zaleznosci

        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
