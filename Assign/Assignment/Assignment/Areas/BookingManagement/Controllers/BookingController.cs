using Assignment.Areas.BookingManagement.Models;
using Assignment.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Assignment.Models;


namespace Assignment.Areas.BookingManagement.Controllers
{
    [Area("BookingManagement")]
    [Route("[area]/[controller]/[action]")]
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
            public async Task<IActionResult> FilteredDetails(int bookingId, string bookingType)
            {
                if (bookingType.Equals("Car"))
                {
                    var carBooking = await _context.cBookings
                                        .Include(cb => cb.car)
                                        .Include(cb => cb.booking)
                                        .FirstOrDefaultAsync(c => c.booking.id == bookingId);
                    return View(carBooking);
                }
                else if (bookingType.Equals("Flight"))
                {
                    var flightBooking = await _context.fBookings
                                            .Include(fb => fb.flight)
                                            .Include(fb => fb.booking)
                                            .FirstOrDefaultAsync(f => f.booking.id == bookingId);

                    return View(flightBooking);
                }
                else
                {
                    var hotelBooking = await _context.hBookings
                                            .Include(hb => hb.hotel)
                                            .Include(hb => hb.booking)
                                            .FirstOrDefaultAsync(h => h.booking.id == bookingId);
                    return View(hotelBooking);
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

