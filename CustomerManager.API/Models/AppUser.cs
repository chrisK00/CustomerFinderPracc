using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManager.API.Models
{ 
    public class AppUser
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }
        public string LookingFor { get; set; }
        public ICollection<Photo> Photos { get; set; } = new List<Photo>();
    }
}
