using System.ComponentModel.DataAnnotations;

namespace mvc_formy.Models
{
    public class User
    {

        public int Id { get; set; }

        [Display(Name ="Nazwa użytkownika")]
        [Required(ErrorMessage = "Nazwa użytkownika jest wymagana")]
        public string Username { get; set; }

        [Display(Name = "Imię")]
        [Required(ErrorMessage = "Imię jest wymagane")]
        public string Name { get; set; }

        [Display(Name = "Nazwisko")]
        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        public string Surname { get; set; }

        [Display(Name = "Adres")]
        [Required(ErrorMessage = "Adres jest wymagany")]
        public string Address { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email jest wymagane")]
        public string Mail { get; set; }

        [Display(Name = "Hasło")]
        [Required(ErrorMessage = "Hasło jest wymagane")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Potwierdź hasło")]
        [Compare("Password", ErrorMessage = "Hasła nie są takie same")]
        [Required(ErrorMessage = "Hasło jest wymagane")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

    }
}
