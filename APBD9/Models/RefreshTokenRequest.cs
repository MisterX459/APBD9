using System.ComponentModel.DataAnnotations;

namespace APBD9.Models
{
    public class RefreshTokenRequest
    {
        [Required]
        public string RefreshToken { get; set; }
    }
}