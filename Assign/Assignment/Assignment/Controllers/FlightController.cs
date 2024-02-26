using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    public class FlightController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FlightController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("departure", "arrival", "depTime", "arrTime", "airline", "price", "maxPassanger", "numPassanger = 0")]Flight flight )
        {
            

            if (ModelState.IsValid)
            {
                _context.flights.Add(flight);
                _context.SaveChanges();
                return RedirectToAction("Index","Car");
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
