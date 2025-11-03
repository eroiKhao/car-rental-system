using System.ComponentModel.DataAnnotations;

namespace Car_Rental_System.Models
{
    public sealed class Client : User
    {
        [Required]
        [StringLength(20)]
        public string? PassportDetails { get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}   
