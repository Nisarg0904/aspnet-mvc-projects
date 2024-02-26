using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class CarBooking 
    {
        [Key]
        public int bId { get; set; }
        [Required]
        public int carId { get; set; }
        [Required]
        public required Car car { get; set; }
        public int id { get; set; }
        [Required]
        public Booking? booking { get; set; }
    }
}
