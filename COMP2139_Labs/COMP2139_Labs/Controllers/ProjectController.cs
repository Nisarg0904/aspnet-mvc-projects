using COMP2139_Labs.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP2139_Labs.Controllers
{
    public class ProjectController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var project = new List<Project>()
            {
                new Project { ProjectId = 1,Name="Project 1", Description="My First Project" }

            };
            return View(project);
        }


        [HttpPost]
        public IActionResult Create(Project project)
        {
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var project=new Project { ProjectId = id, Name="Project name" + id,Description="Project describtion "+id };
            return View(project);
        }

    }
}
