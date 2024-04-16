using Assignment.Areas.BookingManagement.Models;
using Assignment.Areas.ServiceManagement.Models;
using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment.Areas.BookingManagement.Controllers
{
    [Area("BookingManagement")]
    [Route("[area]/[controller]/[action]")]
    public class HotelBookingController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IEmailSender _emailSender;


        private readonly ApplicationDbContext _context;

        public HotelBookingController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager, ApplicationDbContext context, SignInManager<ApplicationUser> signInMananger, IEmailSender emailSender)
        {
            _context = context;
            _roleManager = roleManager;
            _userManager = userManager;
            _signInManager = signInMananger;
            _emailSender = emailSender;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var hotels = await _context.hotels.ToListAsync();
            return View(hotels);
        }

        [HttpGet]
        public async Task<IActionResult> Create(string City, int numRooms)
        {
            var filteredHotels = await _context.hotels
                .Where(h => h.city == City && h.numRooms - numRooms > 0)
                .ToListAsync();
            return View(filteredHotels);
        }
        [HttpGet]
        public async Task<IActionResult> HotelSearch(string searchType, string searchString)
        {
            var filteredHotels = await _context.hotels.ToListAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                switch (searchType)
                {
                    case "Name":
                        filteredHotels = filteredHotels.Where(h => h.name.Contains(searchString)).ToList();
                        break;
                    case "City":
                        filteredHotels = filteredHotels.Where(h => h.city.Contains(searchString)).ToList();
                        break;
                }
            }

            return View("Create", filteredHotels);
        }


        [HttpGet]
        public async Task<IActionResult> ConfirmCreate(int hotelId)
        {
            var hotel = await _context.hotels.Where(h => h.id == hotelId).ToListAsync();
            return View(hotel);
        }

        [HttpGet]
        public async Task<IActionResult> Confirmation(int hotelId, int numberOfRooms, DateTime checkInDate, DateTime checkOutDate)
        {
            var hotel = await _context.hotels.FirstOrDefaultAsync(h => h.id == hotelId);
            if (hotel == null)
            {
                return NotFound();
            }

            var booking = new Booking
            {
                date = DateTime.Today,
                price = hotel.price * numberOfRooms * (checkOutDate - checkInDate).Days,
            };
            if (_signInManager.IsSignedIn(User))
            {
                booking.user = await _userManager.GetUserAsync(User);

            }
            _context.bookings.Add(booking);
            await _context.SaveChangesAsync();

            var hotelBooking = new HotelBooking
            {
                hotelId = hotelId,
                booking = booking,
                hotel = hotel,
                CheckInDate = checkInDate,
                CheckOutDate = checkOutDate,
                NumRooms = numberOfRooms,
            };
            _context.hBookings.Add(hotelBooking);

            hotel.numRooms = hotel.numRooms - numberOfRooms;

            await _context.SaveChangesAsync();
            if (booking.user != null)
            {
                var subject = "Hotel Booking Confirmation";
                var message = $"Namaste! {booking.user.UserName},<br>" +
                              $"Your Hotel booking in {hotel.name} has been confirmed with Booking id: {booking.id}. Below are the details:<br><br>" +
                              $"City: {hotel.city}<br>" +
                              $"Location: {hotel.location}<br>" +
                              $"Check In Date: {hotelBooking.CheckInDate.ToString("yyyy-MM-dd")}<br>" +
                              $"Check Out Date: {hotelBooking.CheckOutDate.ToString("yyyy-MM-dd")}<br>" +
                              $"Total Price: ${booking.price}<br><br>" +
                              $"Thank you for booking with us.";

                await _emailSender.SendEmailAsync(booking.user.Email, subject, message);
            }


            return View(hotelBooking);
        }

    }
}
