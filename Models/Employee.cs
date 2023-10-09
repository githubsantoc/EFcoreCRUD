using System.ComponentModel.DataAnnotations;

namespace EFcore.Models
{
    public class Employee
    {
        public int id { get; set; }
       
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Email { get; set; }
    }
}
