using System.ComponentModel.DataAnnotations;

namespace formularzDawid.Models
{
    public class Rejestracja
    {
        [Required(ErrorMessage = "Imię jest wymagane.")]
        [MinLength(2, ErrorMessage = "Imię musi mieć co najmniej 2 znaki.")]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Nazwisko jest wymagane.")]
        [MinLength(2, ErrorMessage = "Nazwisko musi mieć co najmniej 2 znaki.")]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Adres e-mail jest wymagany.")]
        [EmailAddress(ErrorMessage = "Nieprawidłowy adres e-mail.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Hasło jest wymagane.")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Hasło musi mieć co najmniej 8 znaków.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$", ErrorMessage = "Hasło musi zawierać co najmniej jedną cyfrę, jedną dużą literę i jedną małą literę.")]
        public string Haslo { get; set; }

        [Required(ErrorMessage = "Potwierdzenie hasła jest wymagane.")]
        [Compare("Haslo", ErrorMessage = "Hasło i potwierdzenie hasła muszą być identyczne.")]
        public string PotwierdzenieHasla { get; set; }

        [Required(ErrorMessage = "Numer telefonu jest wymagany.")]
        [Phone(ErrorMessage = "Nieprawidłowy numer telefonu.")]
        public string NrTelefonu { get; set; }

        [Required(ErrorMessage = "Wiek jest wymagany.")]
        [Range(11, 80, ErrorMessage = "Wiek musi być pomiędzy 11 a 80.")]
        public int Wiek { get; set; }

        [Required(ErrorMessage = "Miasto jest wymagane.")]
        public Miasta Miasto { get; set; }

        public enum Miasta
        {
            Warszawa,
            Kraków,
            Gdańsk,
            Poznań,
            Wrocław
        }
    }
}
