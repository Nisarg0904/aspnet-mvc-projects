using Assignment.Areas.BookingManagement.Models;
using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Assignment.Areas.BookingManagement.Controllers
{
    [Area("BookingManagement")]
    [Route("[area]/[controller]/[action]")]
    public class FlightBookingController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FlightBookingController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var flights = await _context.flights.ToListAsync();
            return View(flights);
        }

        [HttpGet]
        public async Task<IActionResult> Create(string departureCity, string arrivalCity, DateTime date)
        {
            var filteredFlights = await _context.flights
                .Where(f => f.departure == departureCity && f.arrival == arrivalCity && f.depTime.Date == date.Date && f.numPassanger < f.maxPassanger)
                .ToListAsync();

            // Pass the filtered list of flights to the view
            return View(filteredFlights);
        }

        public async Task<IActionResult> ConfirmCreate(int flightId)
        {
            var flight = await _context.flights.Where(f => f.id == flightId).ToListAsync();
            return View(flight);
        }

        public async Task<IActionResult> Confirmation(int flightId)
        {
            // Fetch the flight details
            var flight = await _context.flights.FirstOrDefaultAsync(f => f.id == flightId);

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
            await _context.SaveChangesAsync();

            // Create a new flight booking using the generated booking ID and flight ID
            var flightBooking = new FlightBooking
            {
                flightId = flightId,
                booking = booking,
                flight = flight
            };
            _context.fBookings.Add(flightBooking);

            // Increment the numPassanger property of the flight
            flight.numPassanger++;

            await _context.SaveChangesAsync();

            // Redirect to the confirmation view
            return View(flightBooking);
        }

    }
}
