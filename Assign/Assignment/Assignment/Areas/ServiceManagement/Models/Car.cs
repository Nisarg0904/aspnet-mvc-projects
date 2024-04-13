using System.ComponentModel.DataAnnotations;

namespace Assignment.Areas.ServiceManagement.Models
{
    public class Car
    {
        [Key]
        public int id { get; set; }
        [Required]
        public required string model { get; set; }
        public string? type { get; set; }
        [Required]
        public double price { get; set; }
        [Required]
        public required string rentalCompanies { get; set; }
        [Required]
        public required string location { get; set; }
        [Required]
        public required bool isAvailable { get; set; }
        [Required]
        public required DateTime availableFrom { get; set; }



    }
}
