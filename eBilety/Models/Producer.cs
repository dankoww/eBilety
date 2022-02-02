using eBilety.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eBilety.Models
{
    public class Producer : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Zdjęcie")]
        [Required(ErrorMessage = "Zdjęcie profilowe jest wymagane")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Imię i nazwisko")]
        [Required(ErrorMessage = "Imię i nazwisko są wymagane")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Imię i nazwisko muszą mieć od 3 do 50 znaków")]
        public string FullName { get; set; }
        [Display(Name = "Biografia")]
        [Required(ErrorMessage = "Biografia jest wymagana")]
        public string Bio { get; set; }


        //Zaleznosci

        public List<Movie> Movie { get; set; }
    }
}
