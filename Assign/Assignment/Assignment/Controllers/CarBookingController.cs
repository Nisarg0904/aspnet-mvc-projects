using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    public class CarBookingController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CarBookingController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var cars = _context.cars.Where(c=> c.isAvailable).ToList();
            return View(cars);
        }
        [HttpGet]
        public IActionResult Create(string city, DateTime date)
        {
            var filteredCras = _context.cars.Where(c => c.location == city && c.isAvailable && c.availableFrom < date).ToList();
            return View(filteredCras);

        }
        [HttpGet]
        public IActionResult ConfirmCreate(int carId)
        {
            var car = _context.cars.Where(c => c.id == carId).ToList();
            return View(car);

        }

        [HttpGet]
        public IActionResult Confirmation(int carId, DateTime pickupDate, DateTime returnDate)
        {
            var car = _context.cars.FirstOrDefault(c => c.id == carId);
            if (car == null)
            {
                return NotFound();
            }

            var booking = new Booking
            {
                date = DateTime.Today,
                price = car.price *  (returnDate - pickupDate).Days,
            };
            _context.bookings.Add(booking);
            _context.SaveChanges();

            var carBooking = new CarBooking
            {
                car = car,
                booking = booking,
                bookedFrom=pickupDate,
                bookedTo=returnDate
               
             
            };
            _context.cBookings.Add(carBooking);

            car.isAvailable = false;

            _context.SaveChanges();


            return View(carBooking);

        }
    }
        
        
}
