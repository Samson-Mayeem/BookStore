using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Space
    {
        [Key]
        public int SpaceId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public decimal? Price { get; set; }
    }  
}