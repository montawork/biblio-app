using System.ComponentModel.DataAnnotations;

namespace Server.Models
{
    public class LoginUser
    {
        [Required]
        [EmailAddress]
        public string LoginEmail { get; set; }
        [DataType(DataType.Password)]
        [Required]
        [MinLength(8, ErrorMessage = "Password must be 8 characters or longer!")]
        public string LoginPassword { get; set; }
    }
}
