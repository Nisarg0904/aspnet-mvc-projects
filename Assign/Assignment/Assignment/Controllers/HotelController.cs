using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    public class HotelController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HotelController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("name", "city", "location", "price", "numRooms", "amenities")]Hotel hotel)
        {

            if (ModelState.IsValid)
            {
                _context.hotels.Add(hotel);
                _context.SaveChanges();
                return RedirectToAction("Index", "Car");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Create(int a)
        {
            
            return View();
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var hotels=_context.hotels.ToList();

            return View(hotels);
        }
        [HttpPost]
        public IActionResult DeleteHotel(int id)
        {

            var hotel = _context.hotels.Find(id);
            if (hotel == null) return NotFound();
            var booking = _context.hBookings.Where(h => h.hotelId == id);
            if (booking.Any())
            {
                return View("BookingAssociatedError");
            }
            _context.hotels.Remove(hotel);
            _context.SaveChanges();


            return RedirectToAction("Index", "Car");

            return View();
        }
        [HttpPost, ActionName("DeleteConfirmed")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {

            return NotFound();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit()
        {
            return View();
        }
    }
}
