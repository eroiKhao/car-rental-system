namespace Car_Rental_System.Models
{
    public sealed class Client : User
    {
        public string? PassportDetails { get; set; }
        public List<Order> Orders { get; set; }
    }
}   
