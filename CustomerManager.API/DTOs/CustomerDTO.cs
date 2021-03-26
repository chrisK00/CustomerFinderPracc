using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManager.API.DTOs
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        public string LookingFor { get; set; }
        public string MainPhotoUrl { get; set; }
        public ICollection<PhotoDTO> Photos { get; set; } = new List<PhotoDTO>();
    }
}
