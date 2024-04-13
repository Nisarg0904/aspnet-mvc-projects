using System.ComponentModel.DataAnnotations;

namespace Assignment.Areas.ServiceManagement.Models
{
    public class Hotel
    {
        [Key]
        public int id { get; set; }
        [Required]
        public required string name { get; set; }
        [Required]
        public required string city { get; set; }
        public required string location { get; set; }
        [Required]
        public double price { get; set; }

        [Required]
        public int numRooms { get; set; }
        public string? amenities { get; set; }
    }
}
