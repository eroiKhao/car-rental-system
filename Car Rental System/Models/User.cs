using System.Text.Json.Serialization;

namespace Car_Rental_System.Models
{
    public class User : Entity
    {
        [JsonIgnore]
        public string? Name { get; set; }
        [JsonIgnore]
        public string? Email { get; set; }
    }
}
