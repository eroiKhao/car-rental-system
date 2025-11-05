using System.ComponentModel.DataAnnotations;

namespace CarRentalSystem.Models
{
    public sealed class Client : User
    {
        [Required]
        [StringLength(20)]
        public string? PassportDetails { get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}   
