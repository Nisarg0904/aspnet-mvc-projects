using COMP2139_Labs.Data;
using COMP2139_Labs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace COMP2139_Labs.Controllers
{
    public class ProjectController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ProjectController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult Index()
        {
           /* 
            var project = new List<Project>()
            {
                new Project { ProjectId = 1,Name="Project 1", Description="My First Project" }

            };
           */
            

            var project = _context.projects.ToList();
            return View(project);
        }


        [HttpPost]
        public IActionResult Create(Project project)
        {
            if(ModelState.IsValid)
            {
                // add new project
                _context.projects.Add(project);
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
        public IActionResult Details(int id)
        {
           // var project = _context.projects.Where(project.Id == id);
          // var project=new Project { ProjectId = id, Name="Project name" + id,Description="Project describtion "+id };
          var project = _context.projects.FirstOrDefault(p => p.ProjectId == id);
            if (project == null)
            {
                return NotFound();
            }
            return View(project);
        }
        [HttpGet]
        public IActionResult Delete(int id) {
            var project = _context.projects.Find(id);
            if (project == null)
            { return NotFound(); }
            return View(project);
        }
        [HttpPost, ActionName("DeleteConfirmed")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var project = _context.projects.Find(id);
            if (project != null)
            {
                _context.projects.Remove(project);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var project = _context.projects.Find(id);
                if(project == null)
            {  return NotFound(); }
            
                return View(project);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("ProjectId,Name,Description")] Project project)
        {
            if(id!=project.ProjectId)
            {
                return NotFound();
            }
            if(ModelState.IsValid)
            {
                try
                {
                    _context.projects.Update(project);
                    _context.SaveChanges();

                }
                catch(DbUpdateConcurrencyException) {
                    if(!ProjectExist(project.ProjectId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }

                }
            }
            return View(project);
        }
        public bool ProjectExist(int id)
        {
            return _context.projects.Any(e => e.ProjectId == id);
        }

    }
}
