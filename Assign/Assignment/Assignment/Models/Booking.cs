using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class Booking
    {
        [Key]
        public int id {  get; set; }
        public required DateTime date { get; set; }
        public required double price {  get; set; }
        public User? user { get; set; }
     
    }
}
