using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
