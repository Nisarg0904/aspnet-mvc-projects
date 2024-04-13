using Assignment.Areas.ServiceManagement.Models;
using Assignment.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Assignment.Models;


namespace Assignment.Areas.ServiceManagement.Controllers
{
    [Area("ServiceManagement")]
    [Route("[area]/[controller]/[action]")]
    public class CarController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CarController(ApplicationDbContext context)
        {
            _context = context;


        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("model", "type", "price", "rentalCompanies", "location", "isAvailable", "availableFrom")] Car car)
        {
            if (ModelState.IsValid)
            {
                _context.cars.Add(car);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Create(int a)
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var cars = await _context.cars.ToListAsync();
            return View(cars);
        }

        [HttpPost]
        public IActionResult DeleteCar(int id)
        {
            var car = _context.cars.Find(id);
            if (car == null) return NotFound();
            var booking = _context.cBookings.Where(c => c.carId == id);
            if (booking.Any())
            {
                return View("BookingAssociatedError");
            }
            _context.cars.Remove(car);
            _context.SaveChanges();

            return RedirectToAction("Index", "Car");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var car = _context.cars.Find(id);
            if (car == null) return NotFound();

            return View(car);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditCar(Car car)
        {
            if (ModelState.IsValid)
            {
                // Update the car details in the database
                _context.cars.Update(car);
                _context.SaveChanges();

                return RedirectToAction("Details", "Car"); // Redirect to the car list page
            }

            // If model state is not valid, redisplay the form with validation errors
            return View(car);
        }

    }
}
