using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CarRentalSystem.Generic.Models;
namespace CarRentalSystem.Models
{
    public class Order : Entity
    {
        [ForeignKey("Client")]
        public Guid ClientID { get; set; }
        public Client Client { get; set; }

        [ForeignKey("RentedCar")]
        public Guid CarID { get; set; }
        public Car RentedCar { get; set; }
        public int? RentalDays { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalPrice { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; } = "Pending";

        [StringLength(500)]
        public string? RejectionReason { get; set; }
    }
}