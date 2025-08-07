using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace BlazorWASMPortfolio.Pages
{
    public partial class Contact
    {
        private ContactForm _contactForm = new ContactForm();

        private bool _isInvalidForm = true;

        private void ValidateForm()
        {
            _isInvalidForm = string.IsNullOrWhiteSpace(_contactForm.Name) ||
                            string.IsNullOrWhiteSpace(_contactForm.LastName) ||
                            string.IsNullOrWhiteSpace(_contactForm.Country) ||
                            string.IsNullOrWhiteSpace(_contactForm.Email) ||
                            !Regex.IsMatch(_contactForm.Email?? "aa", @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$") ||
                            string.IsNullOrWhiteSpace(_contactForm.Query);            
        }

    }

    public class ContactForm
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        public string? City { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Correo inválido")]
        public string Email { get; set; }
        public string? Tel { get; set; }
        [Required]
        public string Query { get; set; }
    }
}
