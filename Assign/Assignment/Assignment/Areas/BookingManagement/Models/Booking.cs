using System.ComponentModel.DataAnnotations;
using Assignment.Areas.ServiceManagement.Models;

namespace Assignment.Areas.BookingManagement.Models
{
    public class Booking
    {
        [Key]
        public int id { get; set; }
        public required DateTime date { get; set; }
        public required double price { get; set; }


    }
}
