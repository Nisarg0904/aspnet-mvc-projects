using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class Hotel
    {
        [Key]
        public int id {  get; set; }
        public required string location { get; set; }
        [Required]
        public double price { get; set; }
        [Required]
        public int maxRooms { get; set; }
        [Required]
        public int numRooms { get; set;}
        public string? amenities { get; set; }
    }
}
