using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment.Controllers
{
    public class HotelBookingController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HotelBookingController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var hotels= _context.hotels.ToList();
            return View(hotels);
        }
        [HttpGet]
        public IActionResult Create(string City, int numRooms)
        {
            var filteredHotels = _context.hotels
            .Where(h => h.city == City && h.numRooms-numRooms>0)
            .ToList();
            return View(filteredHotels);

        }
        [HttpGet]
        public IActionResult ConfirmCreate(int hotelId, string msg)
        {

            if (msg != null)
            {
                
            }
                var hotel = _context.hotels.Where(h => h.id == hotelId).ToList();
                return View(hotel);
            
        }
        [HttpGet]
        public IActionResult Confirmation(int hotelId,int numberOfRooms,DateTime checkInDate, DateTime checkOutDate) 
        {
            var hotel= _context.hotels.FirstOrDefault(h => h.id==hotelId);
            if (hotel == null)
            {
                return NotFound();
            }

            var booking = new Booking
            {
                date = DateTime.Today,
                price = hotel.price * numberOfRooms * (checkOutDate-checkInDate).Days,
            };
            _context.bookings.Add(booking);
            _context.SaveChanges();

            var hotelBooking= new HotelBooking
            {
                hotelId= hotelId,
                booking = booking,
                hotel=hotel,
                CheckInDate = checkInDate,
                CheckOutDate = checkOutDate,
                NumRooms = numberOfRooms,
            };
            _context.hBookings.Add(hotelBooking);

            hotel.numRooms = hotel.numRooms - numberOfRooms;

            _context.SaveChanges();


            return View(hotelBooking);

        }
    }
}
