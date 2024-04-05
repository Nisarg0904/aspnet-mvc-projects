using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class HotelBooking
    {
        [Key]
        public int bId { get; set; }
        [Required]
        public int hotelId { get; set; }
        [Required]
        public required Hotel hotel { get; set; }
        [Required]
        public DateTime CheckInDate { get; set; }
        [Required]
        public DateTime CheckOutDate { get; set; }
        [Required]
        public int NumRooms { get; set; }
      
        [Required]
        public required Booking  booking { get; set; }


    }
}
