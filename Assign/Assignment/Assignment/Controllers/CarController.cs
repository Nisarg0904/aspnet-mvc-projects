using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Controllers
{
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
        public IActionResult Create([Bind("model","type","price", "rentalCompanies","location", "isAvailable", "availableFrom")] Car car)
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
        public IActionResult Details(int id)
        {
            var cars= _context.cars.ToList();
            return View(cars);
        }
        [HttpPost]
        public IActionResult DeleteCar(int id)
        {
            var car= _context.cars.Find(id);
            if(car == null) return NotFound();
            var booking = _context.cBookings.Where(c => c.carId == id);
            if (booking.Any())
            {
                return View("BookingAssociatedError");
            }
            _context.cars.Remove(car);
            _context.SaveChanges();
        
           
            return RedirectToAction("Index","Car");
        }
        [HttpPost, ActionName("DeleteConfirmed")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
          
            return NotFound();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit()
        {
            return View();
        }

    }
}
