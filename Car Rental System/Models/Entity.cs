using System.ComponentModel.DataAnnotations;

namespace Car_Rental_System.Models
{
    public abstract class Entity
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
