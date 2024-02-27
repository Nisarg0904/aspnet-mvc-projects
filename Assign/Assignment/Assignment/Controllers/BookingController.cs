using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public IActionResult CreateFlightBooking([Bind( "Id","flight", "date = @DateTime.Now.ToString(\"yyyy-MM-ddTHH:mm\")","price")]FlightBooking fBooking)
        {
            if (ModelState.IsValid)
            {
                // add new booking
                _context.fBookings.Add(fBooking);
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
        public IActionResult FilteredDetails(int bookingId, string bookingType)
        {
            if(bookingType.Equals("Car"))
            {
                var carBooking = _context.cBookings
                                   .Include(cb => cb.car)  // Include Flight navigation property
                                   .Include(cb => cb.booking) // Include Booking navigation property
                                   .FirstOrDefault(c => c.booking.id == bookingId); 
                return View(carBooking);

            }
            if (bookingType.Equals("Flight"))
            {
                var flightBooking = _context.fBookings
                    .Include(fb => fb.flight)  // Include Flight navigation property
                    .Include(fb => fb.booking) // Include Booking navigation property
                    .FirstOrDefault(f => f.booking.id == bookingId);

                return View(flightBooking);
            }
            var hotelBooking = _context.hBookings
                               .Include(hb => hb.hotel)  // Include Flight navigation property
                               .Include(hb => hb.booking) // Include Booking navigation property
                               .FirstOrDefault(h => h.booking.id == bookingId); return View(hotelBooking);
        }
        [HttpGet]
        public IActionResult DeleteCarBooking(int bookingId)
        {
            var carBooking = _context.cBookings
                                           .Include(cb => cb.car)  // Include Flight navigation property
                                           .Include(cb => cb.booking) // Include Booking navigation property
                                           .FirstOrDefault(c => c.booking.id == bookingId);
            return View(carBooking);
        }
        [HttpPost]
        public IActionResult DeleteCBooking(int bookingId)
        {
            var carBooking = _context.cBookings
                                           .Include(cb => cb.car)  // Include Flight navigation property
                                           .Include(cb => cb.booking) // Include Booking navigation property
                                           .FirstOrDefault(c => c.booking.id == bookingId);
            var booking = _context.bookings.Find(bookingId);
            var cBooking = _context.cBookings.Find(carBooking.bId);
            if(booking != null && cBooking != null)
            {
                _context.bookings.Remove(booking);
                _context.cBookings.Remove(carBooking);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }
        [HttpGet]
        public IActionResult DeleteHotelBooking(int bookingId)
        {
            var hotelBooking = _context.hBookings
                               .Include(hb => hb.hotel)  // Include Flight navigation property
                               .Include(hb => hb.booking) // Include Booking navigation property
                               .FirstOrDefault(h => h.booking.id == bookingId); return View(hotelBooking);
        
            return View(hotelBooking);
        }
        [HttpPost]
        public IActionResult DeleteHBooking(int bookingId)
        {

            var hotelBooking = _context.hBookings
                               .Include(hb => hb.hotel)  // Include Flight navigation property
                               .Include(hb => hb.booking) // Include Booking navigation property
                               .FirstOrDefault(h => h.booking.id == bookingId); 

            var booking = _context.bookings.Find(bookingId);
            var hBooking = _context.hBookings.Find(hotelBooking.bId);
            if (booking != null && hBooking != null)
            {
                _context.bookings.Remove(booking);
                _context.hBookings.Remove(hBooking);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }
        [HttpGet]
        public IActionResult DeleteFlightBooking(int bookingId)
        {
            var flightBooking = _context.fBookings
                    .Include(fb => fb.flight)  // Include Flight navigation property
                    .Include(fb => fb.booking) // Include Booking navigation property
                    .FirstOrDefault(f => f.booking.id == bookingId);
            return View(flightBooking);
        }
        [HttpPost]
        public IActionResult DeleteFBooking(int bookingId)
        {

            var flightBooking = _context.fBookings
                    .Include(fb => fb.flight)  // Include Flight navigation property
                    .Include(fb => fb.booking) // Include Booking navigation property
                    .FirstOrDefault(f => f.booking.id == bookingId);

            var booking = _context.bookings.Find(bookingId);
            var fBooking = _context.fBookings.Find(flightBooking.bId);
            if (booking != null && fBooking != null)
            {
                _context.bookings.Remove(booking);
                _context.fBookings.Remove(fBooking);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }

    }
}
