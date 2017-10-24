using System.ComponentModel.DataAnnotations;

namespace CustomValidationDemo.Models
{
    public class User
    {

        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        [EmailExists]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        
    }
}