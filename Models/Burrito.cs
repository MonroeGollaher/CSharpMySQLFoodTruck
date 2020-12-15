using System.ComponentModel.DataAnnotations;

namespace csharpfoodtruck.Models
{
    public class Burrito
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(80)]
        public string Title { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }

    }
}