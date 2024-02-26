using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    public class HotelController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HotelController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("name", "city", "location", "price", "numRooms", "amenities")]Hotel hotel)
        {

            if (ModelState.IsValid)
            {
                _context.hotels.Add(hotel);
                _context.SaveChanges();
                return RedirectToAction("Index", "Car");
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
