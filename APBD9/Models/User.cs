using System.ComponentModel.DataAnnotations;

namespace APBD9.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string PasswordHash { get; set; }
        public string RefreshToken { get; set; }
    }
}