using Assignment.Areas.BookingManagement.Models;
using Assignment.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Assignment.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Dynamic;



namespace Assignment.Areas.BookingManagement.Controllers
{
    [Area("BookingManagement")]
    [Route("[area]/[controller]/[action]")]
    public class BookingController : Controller
    {

        private readonly ILogger<BookingController> _logger;

        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IEmailSender _emailSender;


        private readonly ApplicationDbContext _context;

        public BookingController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager, ApplicationDbContext context, SignInManager<ApplicationUser> signInMananger, IEmailSender emailSender, ILogger<BookingController> logger)
        {
            _context = context;
            _roleManager = roleManager;
            _userManager = userManager;
            _signInManager = signInMananger;
            _emailSender = emailSender;
            _logger = logger;
        }

        public IActionResult Index()
            {

            _logger.LogInformation("Calling BookingController Index() Action");
            
                return View();
            }

            [HttpPost("")]
            public async Task<IActionResult> CreateFlightBooking([Bind("Id", "flight", "date = @DateTime.Now.ToString(\"yyyy-MM-ddTHH:mm\")", "price")] FlightBooking fBooking)
            {

                if (ModelState.IsValid)
                {
                    // add new booking
                    _context.fBookings.Add(fBooking);
                    await _context.SaveChangesAsync();
                }

                return RedirectToAction("Index");
            }

            [HttpGet]
            public IActionResult Create()
            {
                return View();
            }

            [HttpGet]
            public async Task<IActionResult> CreateCar()
            {
                var cars = await _context.cars.ToListAsync();
                return View(cars);
            }

            [HttpGet]
            public async Task<IActionResult> CreateHotel()
            {
                var hotels = await _context.hotels.ToListAsync();
                return View(hotels);
            }

            [HttpGet]
            public async Task<IActionResult> Details(int id)
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
        public async Task<IActionResult> SDetails()
        {
            // Get the currently signed-in user
            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null)
            {
                // Handle if the user is not signed in
                return RedirectToAction("Login", "Account"); // Redirect to login page
            }

            // Fetch all bookings associated with the current user
            var userBookings = await _context.bookings
                .Include(b => b.user)
                .Where(b => b.user == currentUser)
                .ToListAsync();

            return View(userBookings);
        }

        [HttpGet]
        public async Task<IActionResult> FilteredDetails(int bookingId, string bookingType)
        {
           
                switch (bookingType)
                {
                    case "Car":
                        var carBooking = await _context.cBookings
                            .Include(cb => cb.car)
                            .Include(cb => cb.booking)
                            .FirstOrDefaultAsync(cb => cb.booking.id == bookingId);
                        return View("filteredDetails", carBooking);
                    case "Flight":
                        var flightBooking = await _context.fBookings
                            .Include(fb => fb.flight)
                            .Include(fb => fb.booking)
                            .FirstOrDefaultAsync(fb => fb.booking.id == bookingId);
                        return View("filteredDetails", flightBooking);
                    case "Hotel":
                        var hotelBooking = await _context.hBookings
                            .Include(hb => hb.hotel)
                            .Include(hb => hb.booking)
                            .FirstOrDefaultAsync(hb => hb.booking.id == bookingId);
                        return View("filteredDetails", hotelBooking);
                case "user":
                     carBooking = await _context.cBookings
                            .Include(cb => cb.car)
                            .Include(cb => cb.booking)
                            .FirstOrDefaultAsync(cb => cb.booking.id == bookingId);
                    if(carBooking == null)
                    {
                         flightBooking = await _context.fBookings
                            .Include(fb => fb.flight)
                            .Include(fb => fb.booking)
                            .FirstOrDefaultAsync(fb => fb.booking.id == bookingId);
                        if(flightBooking == null)
                        {
                             hotelBooking = await _context.hBookings
                            .Include(hb => hb.hotel)
                            .Include(hb => hb.booking)
                            .FirstOrDefaultAsync(hb => hb.booking.id == bookingId);
                            return View("filteredDetails", hotelBooking);

                        }
                        return View("filteredDetails", flightBooking);


                    }
                    return View("filteredDetails", carBooking);


                default:
                        // Handle unknown booking type
                        return RedirectToAction("Index", "Home");
                
            }
            }
        



        [HttpGet]
            public async Task<IActionResult> DeleteCarBooking(int bookingId)
            {
                var carBooking = await _context.cBookings
                                        .Include(cb => cb.car)
                                        .Include(cb => cb.booking)
                                        .FirstOrDefaultAsync(c => c.booking.id == bookingId);
                return View(carBooking);
            }

            [HttpPost]
            public async Task<IActionResult> DeleteCBooking(int bookingId)
            {
                var carBooking = await _context.cBookings
                                        .Include(cb => cb.car)
                                        .Include(cb => cb.booking)
                                        .FirstOrDefaultAsync(c => c.booking.id == bookingId);
                var booking = await _context.bookings.FindAsync(bookingId);
                var cBooking = await _context.cBookings.FindAsync(carBooking.bId);
                if (booking != null && cBooking != null)
                {
                    carBooking.car.isAvailable = true;
                    _context.bookings.Remove(booking);
                    _context.cBookings.Remove(carBooking);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
                return NotFound();
            }

            [HttpGet]
            public async Task<IActionResult> DeleteHotelBooking(int bookingId)
            {
                var hotelBooking = await _context.hBookings
                                    .Include(hb => hb.hotel)
                                    .Include(hb => hb.booking)
                                    .FirstOrDefaultAsync(h => h.booking.id == bookingId);
                return View(hotelBooking);
            }

            [HttpPost]
            public async Task<IActionResult> DeleteHBooking(int bookingId)
            {
                var hotelBooking = await _context.hBookings
                                    .Include(hb => hb.hotel)
                                    .Include(hb => hb.booking)
                                    .FirstOrDefaultAsync(h => h.booking.id == bookingId);

                var booking = await _context.bookings.FindAsync(bookingId);
                var hBooking = await _context.hBookings.FindAsync(hotelBooking.bId);
                if (booking != null && hBooking != null)
                {
                    hotelBooking.hotel.numRooms = hotelBooking.hotel.numRooms + hotelBooking.NumRooms;
                    _context.bookings.Remove(booking);
                    _context.hBookings.Remove(hBooking);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
                return NotFound();
            }

            [HttpGet]
            public async Task<IActionResult> DeleteFlightBooking(int bookingId)
            {
                var flightBooking = await _context.fBookings
                                    .Include(fb => fb.flight)
                                    .Include(fb => fb.booking)
                                    .FirstOrDefaultAsync(f => f.booking.id == bookingId);
                return View(flightBooking);
            }

            [HttpPost]
            public async Task<IActionResult> DeleteFBooking(int bookingId)
            {
                var flightBooking = await _context.fBookings
                                    .Include(fb => fb.flight)
                                    .Include(fb => fb.booking)
                                    .FirstOrDefaultAsync(f => f.booking.id == bookingId);

                var booking = await _context.bookings.FindAsync(bookingId);
                var fBooking = await _context.fBookings.FindAsync(flightBooking.bId);
                if (booking != null && fBooking != null)
                {
                    flightBooking.flight.numPassanger--;
                    _context.bookings.Remove(booking);
                    _context.fBookings.Remove(fBooking);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
                return NotFound();
            }
        }


}

