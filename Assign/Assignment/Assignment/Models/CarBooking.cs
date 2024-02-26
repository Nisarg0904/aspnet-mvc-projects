using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class CarBooking :Booking
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public required Car car { get; set; }
    }
}
