using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class FlightBookingv: Booking
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public required Flight flight { get; set; }
    }
}
