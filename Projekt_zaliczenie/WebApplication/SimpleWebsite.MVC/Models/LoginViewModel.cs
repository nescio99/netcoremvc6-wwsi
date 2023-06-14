using System.ComponentModel.DataAnnotations;

namespace SimpleWebsite.MVC.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Pole Użytkownik jest wymagane.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Pole Hasło jest wymagane.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Zapamiętaj mnie")]
        public bool RememberMe { get; set; }
    }
}
