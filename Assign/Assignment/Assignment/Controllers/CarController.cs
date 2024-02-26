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
