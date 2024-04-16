using Assignment.Areas.BookingManagement.Models;
using Assignment.Areas.ServiceManagement.Models;
using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Assignment.Areas.BookingManagement.Controllers
{
    [Area("BookingManagement")]
    [Route("[area]/[controller]/[action]")]
    public class FlightBookingController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IEmailSender _emailSender;


        private readonly ApplicationDbContext _context;

        public FlightBookingController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager, ApplicationDbContext context, SignInManager<ApplicationUser> signInMananger, IEmailSender emailSender)
        {
            _context = context;
            _roleManager = roleManager;
            _userManager = userManager;
            _signInManager = signInMananger;
            _emailSender = emailSender;
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
        public async Task<IActionResult> GeneralSearch(string searchType, string searchString)
        {
            switch (searchType)
            {
                case "ArrivingCity":
                    var filteredFlights = await _context.flights
                        .Where(f => f.arrival.Contains(searchString))
                        .ToListAsync();
                    return View("Create", filteredFlights);
                case "Destination":
                     filteredFlights = await _context.flights
                        .Where(f => f.departure.Contains(searchString))
                        .ToListAsync();
                    return View("Create", filteredFlights);
                case "Airlines":
                    filteredFlights = await _context.flights
                        .Where(f => f.airline.Contains(searchString))
                        .ToListAsync();
                    return View("Create", filteredFlights);
                default:
                    return RedirectToAction("Index");
            }
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
            if (_signInManager.IsSignedIn(User))
            {
                booking.user = await _userManager.GetUserAsync(User);

            }

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
            if (booking.user != null)
            {
                var subject = "Car Booking Confirmation";
                var message = $"Namaste! {booking.user.UserName},<br><br>" +
                              $"Your Flight with {flight.airline} booking has been confirmed with booking id: {booking.id}. Below are the details:<br><br>" +
                              $"From: {flight.departure}<br>" +
                              $"To: {flight.arrival}<br>" +
                              $"{flight.depTime.ToString("yyyy-MM-dd HH:mm")} --> {flight.arrTime.ToString("yyyy-MM-dd HH:mm")} [Note: The Time is the local Time of Place You are Going!]<br>" +
                              $"Total Price: ${booking.price}<br><br>" +
                              $"Viel dank for booking with us.";

                await _emailSender.SendEmailAsync(booking.user.Email, subject, message);
            }

            // Redirect to the confirmation view
            return View(flightBooking);
        }

    }
}
