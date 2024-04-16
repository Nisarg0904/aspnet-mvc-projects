using COMP2139_Labs.Areas.ProjectManagement.Models;
using COMP2139_Labs.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace COMP2139_Labs.Areas.ProjectManagement.Controllers
{
    [Authorize]
    [Area("ProjectManagement")]
    [Route("[area]/[controller]/[action]")]
    public class ProjectController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<ProjectController> _logger;

        public ProjectController(ApplicationDbContext context, ILogger<ProjectController> logger)
        {
            _context = context;
            _logger = logger;
        }


        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            _logger.LogInformation("Calling ProjectController Index() Action");
            var projects = await _context.projects.ToListAsync();
            return View(projects);
        }



        [HttpGet("Details/{id:int}")]
        public async Task<IActionResult> Details(int id)
        {
            _logger.LogInformation("Calling ProjectController Details() Action");
            _logger.LogDebug($"Project Details for Id: {id}");

            var project = await _context.projects.FirstOrDefaultAsync(p => p.ProjectId == id);
            if (project == null)
            {
                return NotFound();
            }
            return View(project);
        }

        [HttpGet("Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("Create")]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Project project)
        {
            if (ModelState.IsValid)
            {
                //add new Project
                _context.projects.Add(project);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            return RedirectToAction("Index");
        }


        [HttpGet("Edit/{id:int}")]
        public async Task<IActionResult> Edit(int id)
        {
            var project = await _context.projects.FindAsync(id);
            if (project == null)
            {
                return NotFound();
            }
            return View(project);

        }

        [HttpPost("Edit/{id:int}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProjectId, Name, Description, StartDate, EndDate, Status")] Project project)
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
                catch (DBConcurrencyException)
                {
                    if (!ProjectExists(project.ProjectId))
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

        public bool ProjectExists(int id)
        {
            return _context.projects.Any(e => e.ProjectId == id);
        }

        [HttpGet("Delete/{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {

            var project = await _context.projects.FirstOrDefaultAsync(p => p.ProjectId == id);
            if (project == null)
            {
                return NotFound();
            }
            return View(project);
        }

        [HttpPost("DeleteConfirmed/{id:int}"), ActionName("DeleteConfirmed")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var project = await _context.projects.FindAsync(id);
            if (project == null)
            {
                _context.projects.Remove(project);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            return NotFound();
        }


        [HttpGet("Search/{searchString?}")]

        public async Task<IActionResult> Search(string searchString)
        {
            var projectQuery = from p in _context.projects select p;

            bool searchPerformed = !string.IsNullOrEmpty(searchString);

            if (searchPerformed)
            {
                projectQuery = projectQuery.Where(p => p.Name.Contains(searchString)
                                                    || p.Description.Contains(searchString));
            }
            var projects = await projectQuery.ToListAsync();
            ViewData["SearchPerfomred"] = searchPerformed;
            ViewData["SearchString"] = searchString;
            return View("Index", projects);


        }

    }
}
