using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class Booking
    {
        [Key]
        public int id {  get; set; }

        public Car? car { get; set; }
        public Hotel? hotel { get; set; }
        public Flight? flight { get; set; }
        public required DateTime date { get; set; }
        public required double price {  get; set; }
        public User? user { get; set; }
     
    }
}
