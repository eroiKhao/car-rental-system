using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Rental_System.Models
{
    public class Order : Entity
    {
        [ForeignKey("CarID")]
        public Car? RentedCar { get; set; }
        public int? RentalDays { get; set; }
        [ForeignKey("ClientID")]
        public Client? Client { get; set; }
        public string? RejectionReason { get; set; }
        public string? Status { get; set; }
    }
}
