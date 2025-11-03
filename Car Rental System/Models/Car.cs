using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic.Devices;

namespace Car_Rental_System.Models
{
    public class Car : Entity
    {
        [Required]
        [StringLength(100)]
        public string? Model { get; set; }
        [Required]
        [StringLength(50)]
        public string? Status { get; set; } = "Available";
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PricePerDay { get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
