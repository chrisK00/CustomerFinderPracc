using System.ComponentModel.DataAnnotations;

namespace CustomerManager.API.DTOs
{
    public class CustomerLoginDTO
    {
        [Required]
        public string Username { get; set; }
    }
}
