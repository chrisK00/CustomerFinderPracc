using System.ComponentModel.DataAnnotations;

namespace CustomerManager.API.DTOs
{
    public class PhotoDTO
    {
        public int Id { get; set; }
        [Required]
        public string Url { get; set; }
        public bool IsMain { get; set; }
    }
}