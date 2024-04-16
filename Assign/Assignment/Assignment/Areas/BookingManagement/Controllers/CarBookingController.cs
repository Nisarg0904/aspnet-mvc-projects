using Assignment.Areas.BookingManagement.Models;
using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Encodings.Web;

namespace Assignment.Areas.BookingManagement.Controllers
{
    [Area("BookingManagement")]
    [Route("[area]/[controller]/[action]")]
    public class CarBookingController : Controller
    {

        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IEmailSender _emailSender;


        private readonly ApplicationDbContext _context;

        public CarBookingController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager,ApplicationDbContext context , SignInManager<ApplicationUser> signInMananger, IEmailSender emailSender)
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
            var cars = await _context.cars.Where(c => c.isAvailable).ToListAsync();
            return View(cars);
        }

        [HttpGet]
        public async Task<IActionResult> Create(string city, DateTime date)
        {
            var filteredCars = await _context.cars.Where(c => c.location == city && c.isAvailable && c.availableFrom < date).ToListAsync();
            return View(filteredCars);
        }
        [HttpGet]
        public async Task<IActionResult> CarSearch(string searchType, string searchString)
        {
            var filteredCars = await _context.cars.Where(c => c.isAvailable).ToListAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                switch (searchType)
                {
                    case "Model":
                        filteredCars = filteredCars.Where(c => c.model.Contains(searchString)).ToList();
                        break;
                    case "Type":
                        filteredCars = filteredCars.Where(c => c.type.Contains(searchString)).ToList();
                        break;
                    case "Location":
                        filteredCars = filteredCars.Where(c => c.location.Contains(searchString)).ToList();
                        break;
                    case "RentalCompanies":
                        filteredCars = filteredCars.Where(c => c.rentalCompanies.Contains(searchString)).ToList();
                        break;
                }
            }

            return View("Create", filteredCars);
        }



        [HttpGet]
        public async Task<IActionResult> ConfirmCreate(int carId)
        {
            var car = await _context.cars.Where(c => c.id == carId).ToListAsync();
            return View(car);
        }

        [HttpGet]
        public async Task<IActionResult> Confirmation(int carId, DateTime pickupDate, DateTime returnDate)
        {
            var car = await _context.cars.FirstOrDefaultAsync(c => c.id == carId);
            if (car == null)
            {
                return NotFound();
            }
           

             var booking = new Booking
            {
                date = DateTime.Today,
                price = car.price * (returnDate - pickupDate).Days
                
               
             };
            if (_signInManager.IsSignedIn(User))
            {
                booking.user=await _userManager.GetUserAsync(User);
               
            }


            _context.bookings.Add(booking);
            await _context.SaveChangesAsync();

            var carBooking = new CarBooking
            {
                car = car,
                booking = booking,
                bookedFrom = pickupDate,
                bookedTo = returnDate
            };
            _context.cBookings.Add(carBooking);

            car.isAvailable = false;

            await _context.SaveChangesAsync();

            if (booking.user != null)
            {
                var subject = "Car Booking Confirmation";
                var message = $"Namaste! {booking.user.UserName},<br><br>" +
                              $"Your car booking with {car.rentalCompanies} has been confirmed with booking id: {booking.id}. Below are the details:<br><br>" +
                              $"Car Model: {car.model}<br>" +
                              $"Pickup Date: {pickupDate}<br>" +
                              $"Return Date: {returnDate}<br>" +
                              $"Total Price: ${booking.price}<br><br>" +
                              $"Viel dank for booking with us.";

                await _emailSender.SendEmailAsync(booking.user.Email, subject, message);
            }



            return View(carBooking);
        }
    }



}
