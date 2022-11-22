using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace mvc_formy.Models
{
    public class Form
    {
        [Required(ErrorMessage = "Imie i nazwisko jest wymagane")]
        [Display(Name = "Imie i nazwisko")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email jest wymagany")]
        [Display(Name = "Email")]
        public string Mail { get; set; }

        [Display(Name = "Numer telefonu")]
        [Required(ErrorMessage = "Numer telefonu jest wymagany")]
        [DataType(DataType.PhoneNumber)]
        public int PhoneNumber { get; set; }

        [Display(Name = "Opis zgłoszenia")]
        [Required(ErrorMessage = "Opis zgłoszenia jest wymagany")]
        public string Description { get; set; }
        public List<SelectListItem> Subject { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "Zamowienia", Text = "Zamówienia" },
            new SelectListItem { Value = "Produkty", Text = "Produkty" },
            new SelectListItem { Value = "Reklamacje", Text = "Reklamacje"}
        };

    }
}
