using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    public class FlightController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FlightController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("departure", "arrival", "depTime", "arrTime", "airline", "price", "maxPassanger", "numPassanger = 0")]Flight flight )
        {
            

            if (ModelState.IsValid)
            {
                _context.flights.Add(flight);
                _context.SaveChanges();
                return RedirectToAction("Index","Car");
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
            var flights = _context.flights.ToList();

            return View(flights);
        }

        [HttpPost]
        public IActionResult DeleteFlight(int id)
        {

            var flight = _context.flights.Find(id);
            if (flight == null) return NotFound();
            var booking = _context.fBookings.Where(f => f.flightId == id);
            if (booking.Any())
            {
                return View("BookingAssociatedError");
            }
            _context.flights.Remove(flight);
            _context.SaveChanges();


            return RedirectToAction("Index", "Car");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var flight = _context.flights.Find(id);
            if (flight == null) return NotFound();


            return View(flight);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Flight flight)
        {

            if (ModelState.IsValid)
            {
                // Update the hotel details in the database
                _context.flights.Update(flight);
                _context.SaveChanges();

                return RedirectToAction("Details", "Flight"); // Redirect to the hotel list page
            }

            // If model state is not valid, redisplay the form with validation errors
            return View(flight);
        }

    }
}
