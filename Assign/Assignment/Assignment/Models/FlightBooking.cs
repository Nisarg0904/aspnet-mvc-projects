using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class FlightBooking 
    {
        [Key]
        public int bId { get; set; }
        [Required]
        public int flightId { get; set; }
        [Required]
        public required Flight flight { get; set; }

        [Required]
        public required Booking booking { get; set; }
    }
}
