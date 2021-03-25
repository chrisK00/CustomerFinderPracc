using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerManager.API.Models
{
    [Table("Photos")]
    public class Photo
    {
        public int Id { get; set; }
        [Required]
        public string Url { get; set; }
        public bool IsMain { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
