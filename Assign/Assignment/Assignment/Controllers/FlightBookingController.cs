using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Controllers
{
    public class FlightBookingController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FlightBookingController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var flights = _context.flights.ToList();
            return View(flights);
            
        }
        [HttpGet]
        public IActionResult Create(string departureCity, string arrivalCity, DateTime date) {
            var filteredFlights = _context.flights
            .Where(f => f.departure == departureCity && f.arrival == arrivalCity && f.depTime.Date == date.Date)
            .ToList();

            // Pass the filtered list of flights to the view
            return View(filteredFlights);

        }
        public IActionResult ConfirmCreate(int flightId)
        {
            var flight= _context.flights.Where(f => f.id == flightId).ToList();
            return View(flight);
        }
        public IActionResult Confirmation (int flightId)
        {
            // Fetch the flight details
            var flight = _context.flights.FirstOrDefault(f => f.id == flightId);

            if (flight == null)
            {
                // Handle case where flight is not found
                return NotFound();
            }

            // Create a new booking with today's date and set its price
            var booking = new Booking
            {
                date = DateTime.Today,
                price = flight.price
                // Set other properties as needed
            };
            _context.bookings.Add(booking);
            _context.SaveChanges();

            // Create a new flight booking using the generated booking ID and flight ID
            var flightBooking = new FlightBooking
            {
                flightId = flightId,
                booking=booking,
                flight=flight
            };
            _context.fBookings.Add(flightBooking);

            // Increment the numPassanger property of the flight
            flight.numPassanger++;

            _context.SaveChanges();

            // Redirect to the confirmation view

            return View(flightBooking);
        }
    }
}
