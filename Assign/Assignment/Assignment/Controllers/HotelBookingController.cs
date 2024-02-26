using Assignment.Data;
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
        public IActionResult ConfirmCreate(int hotelId)
        {

            var hotel = _context.hotels.Where(h => h.id == hotelId).ToList();
            return View(hotel);
        }
    }
}
