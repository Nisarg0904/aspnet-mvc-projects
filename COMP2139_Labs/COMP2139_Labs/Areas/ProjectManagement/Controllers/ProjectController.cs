using COMP2139_Labs.Areas.ProjectManagement.Models;
using COMP2139_Labs.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace COMP2139_Labs.Areas.ProjectManagement.Controllers
{
    [Area("ProjectManagement")]
    [Route ("[area]/[controller]/[action]")]
    public class ProjectController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ProjectController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet ("")]
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


        [HttpPost ("Create")]
        public IActionResult Create(Project project)
        {
            if (ModelState.IsValid)
            {
                // add new project
                _context.projects.Add(project);
                _context.SaveChanges();

            }
            return RedirectToAction("Index");
        }

        [HttpGet ("Create")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpGet("Details/{id:int")]
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
        [HttpGet ("Delete/{id:int}")]
        public IActionResult Delete(int id)
        {
            var project = _context.projects.Find(id);
            if (project == null)
            { return NotFound(); }
            return View(project);
        }
        [HttpPost ("Delete/{id:int}"), ActionName("DeleteConfirmed") ]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int itemid)
        {
            var project = _context.projects.Find(itemid);
            if (project != null)
            {
                _context.projects.Remove(project);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }
        [HttpGet("Search/{searchString?}")]
        public async Task<IActionResult> Search(string searchString)
        {
            var projectQuery = from p in _context.projects
                               select p;
            bool searchPerformed = !string.IsNullOrEmpty(searchString);

            if (searchPerformed)
            {
                projectQuery = projectQuery.Where(p => p.Name.Contains(searchString)
                                                    || p.Description.Contains(searchString));
            }

            var projects = await projectQuery.ToListAsync();

            ViewData["SearchPerformed"] = searchPerformed;
            ViewData["SearchString"] = searchString;

            return View("Index", projects);

        }
        [HttpGet ("Edit/{id:int}")]
        public IActionResult Edit(int id)
        {
            var project = _context.projects.Find(id);
            if (project == null)
            { return NotFound(); }

            return View(project);
        }
        [HttpPost ("Edit/{id:int}")]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("ProjectId,Name,Description")] Project project)
        {
            if (id != project.ProjectId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.projects.Update(project);
                    _context.SaveChanges();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectExist(project.ProjectId))
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
