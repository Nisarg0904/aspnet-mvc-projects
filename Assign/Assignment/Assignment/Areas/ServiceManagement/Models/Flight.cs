using System.ComponentModel.DataAnnotations;

namespace Assignment.Areas.ServiceManagement.Models
{
    public class Flight
    {
        [Key]
        public int id { get; set; }
        [Required]
        public required string departure { get; set; }
        [Required]
        public required string arrival { get; set; }
        [Required]
        public DateTime depTime { get; set; }
        [Required]
        public DateTime arrTime { get; set; }
        public string? airline { get; set; }
        [Required]
        public double price { get; set; }
        [Required]
        public int maxPassanger { get; set; }
        [Required]
        public int numPassanger { get; set; }


    }
}
