using eBilety.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eBilety.Models
{
    public class Cinema:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Logo")]
        [Required(ErrorMessage ="Logo kina jest wymagane")]
        public string Logo { get; set; }
        [Display(Name = "Nazwa")]
        [Required(ErrorMessage = "Nazwa kina jest wymagana")]
        public string Name { get; set; }
        [Display(Name = "Opis")]
        [Required(ErrorMessage = "Opis kina jest wymagany")]
        public string Description { get; set; }

        //Zaleznosci

        public List<Movie> Movies { get; set; }  
    }
}
