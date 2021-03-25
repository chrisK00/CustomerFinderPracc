using System.ComponentModel.DataAnnotations;

namespace CustomerManager.API.DTOs
{
    public class CustomerDTO
    {
        [Required]
        public string Token { get; set; }
        [Required]
        public string Username { get; set; }
    }
}
