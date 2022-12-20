using System.ComponentModel.DataAnnotations;

namespace OpenSpace.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string Status { get; set; }
        public string RoleName { get; set; }
    }
}
