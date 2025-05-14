namespace Car_Rental_System.Models
{
    public class Car : Entity
    {
        public string? Model { get; set; }
        public string? Status { get; set; }
        public decimal? PricePerDay { get; set; }
        public List<Order> Orders { get; set; }
    }
}
