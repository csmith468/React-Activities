using System.ComponentModel.DataAnnotations;

namespace API.DTOs {
    public class RegisterDTO {
        [Required]
        public string DisplayName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        //d: requires number, a-z/A-Z: requires lower/uppercase, {4,8}: 4-8 characters
        [RegularExpression("(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).{4,8}$", ErrorMessage = "Password must be complex.")]
        public string Password { get; set; }
        [Required]
        public string Username { get; set; }
    }

}