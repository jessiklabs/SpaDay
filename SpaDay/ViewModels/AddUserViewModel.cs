using System;
using System.ComponentModel.DataAnnotations;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {

        [Required(ErrorMessage = "Username is required")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Username must be between 5 and 15 characters long")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [StringLength(20, MinimumLength = 6)]
        public string Password { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "Password verification is required")]
        [Compare("Password", ErrorMessage = "Passwords must match!")]
        public string VerifyPassword { get; set; }
    }
}
