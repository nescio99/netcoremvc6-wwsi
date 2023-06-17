using System.ComponentModel.DataAnnotations;

namespace SimpleWebsite.MVC.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nazwa użytkownika jest wymagana.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Hasło jest wymagane.")]
        public string Password { get; set; }
    }
}
