using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    public class BookingController : Controller
    {

        private readonly ApplicationDbContext _context;

        public BookingController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Booking booking)
        {
            if (ModelState.IsValid)
            {
                // add new booking
                _context.bookings.Add(booking);
               _context.SaveChanges();

            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateCar()
        {
            var cars= _context.cars.ToList();
            return View(cars);
        }
        [HttpGet]
        public IActionResult CreateFlight()
        {
            var flights = _context.flights.ToList();
            return View(flights);
        }
        [HttpGet]
        public IActionResult CreateHotel()
        {
            var hotels = _context.hotels.ToList();
            return View(hotels);
        }
    
        [HttpGet]
        
        public IActionResult Details(int id)
        {

            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {

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
