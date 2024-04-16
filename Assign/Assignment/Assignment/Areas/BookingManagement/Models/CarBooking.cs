using System.ComponentModel.DataAnnotations;
using Assignment.Areas.ServiceManagement.Models;

namespace Assignment.Areas.BookingManagement.Models
{
    public class CarBooking
    {
        [Key]
        public int bId { get; set; }
        [Required]
        public int carId { get; set; }
        [Required]
        public required Car car { get; set; }
        public DateTime bookedFrom { get; set; }
        public DateTime bookedTo { get; set; }
        [Required]
        public required Booking booking { get; set; }
    }
}
