namespace Assignment.Models
{
    public class HotelBooking:Booking
    {
        public int Id { get; set; }
        public required Hotel hotel { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int NumRooms { get; set; }

    }
}
