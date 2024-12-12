using System.ComponentModel.DataAnnotations;

namespace CRUDAppp.Models
{
    public class Login
    {
        [Required]
        public string Username { get; set; } = string.Empty;
        public string? Password { get; set; } = string.Empty;
    }
}
