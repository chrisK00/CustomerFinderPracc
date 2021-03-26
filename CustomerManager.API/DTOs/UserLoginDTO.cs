using System.ComponentModel.DataAnnotations;

namespace CustomerManager.API.DTOs
{
    public class UserLoginDTO
    {
        [Required]
        public string Username { get; set; }
    }
}
