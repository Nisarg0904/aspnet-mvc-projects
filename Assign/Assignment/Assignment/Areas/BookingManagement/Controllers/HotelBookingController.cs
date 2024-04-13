using Assignment.Areas.BookingManagement.Models;
using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment.Areas.BookingManagement.Controllers
{
    [Area("BookingManagement")]
    [Route("[area]/[controller]/[action]")]
    public class HotelBookingController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HotelBookingController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var hotels = await _context.hotels.ToListAsync();
            return View(hotels);
        }

        [HttpGet]
        public async Task<IActionResult> Create(string City, int numRooms)
        {
            var filteredHotels = await _context.hotels
                .Where(h => h.city == City && h.numRooms - numRooms > 0)
                .ToListAsync();
            return View(filteredHotels);
        }

        [HttpGet]
        public async Task<IActionResult> ConfirmCreate(int hotelId)
        {
            var hotel = await _context.hotels.Where(h => h.id == hotelId).ToListAsync();
            return View(hotel);
        }

        [HttpGet]
        public async Task<IActionResult> Confirmation(int hotelId, int numberOfRooms, DateTime checkInDate, DateTime checkOutDate)
        {
            var hotel = await _context.hotels.FirstOrDefaultAsync(h => h.id == hotelId);
            if (hotel == null)
            {
                return NotFound();
            }

            var booking = new Booking
            {
                date = DateTime.Today,
                price = hotel.price * numberOfRooms * (checkOutDate - checkInDate).Days,
            };
            _context.bookings.Add(booking);
            await _context.SaveChangesAsync();

            var hotelBooking = new HotelBooking
            {
                hotelId = hotelId,
                booking = booking,
                hotel = hotel,
                CheckInDate = checkInDate,
                CheckOutDate = checkOutDate,
                NumRooms = numberOfRooms,
            };
            _context.hBookings.Add(hotelBooking);

            hotel.numRooms = hotel.numRooms - numberOfRooms;

            await _context.SaveChangesAsync();

            return View(hotelBooking);
        }

    }
}
