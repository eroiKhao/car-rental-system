using System.ComponentModel.DataAnnotations;

namespace Car_Rental_System.Models
{
    public abstract class User : Entity
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; } = string.Empty;
    }
}