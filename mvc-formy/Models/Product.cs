using System.ComponentModel.DataAnnotations;

namespace mvc_formy.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name = "Nazwa przedmiotu")]
        [Required(ErrorMessage = "Nazwa przedmiotu jest wymagana")]
        public string Name { get; set; }

        [Display(Name = "Opis przedmiotu")]
        [Required(ErrorMessage = "Opis przedmiotu jest wymagany")]
        public string Description { get; set; }

        [Display(Name = "Cena")]
        [Required(ErrorMessage = "Cena jest wymagana")]
        public int? Price { get; set; }

        [Display(Name = "Ilość")]
        [Required(ErrorMessage = "Ilość jest wymagana")]
        public int? Quantity { get; set; }
    }
}
