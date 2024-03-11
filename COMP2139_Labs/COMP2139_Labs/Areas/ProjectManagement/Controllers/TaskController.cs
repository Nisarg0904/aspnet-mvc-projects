using COMP2139_Labs.Areas.ProjectManagement.Models;
using COMP2139_Labs.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Threading.Tasks;

namespace COMP2139_Labs.Areas.ProjectManagement.Controllers
{
    public class TaskController : Controller
    {
        private readonly ApplicationDbContext _context;
        public TaskController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index(int projectId)
        {
            var tasks = _context.tasks.Where(t => t.ProjectId == projectId).ToList();
            ViewBag.ProjectId = projectId;
            return View(tasks);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var task = _context.tasks.Include(t => t.Project).FirstOrDefault(task => task.ProjectId == id);
            if (task == null)
            {
                return NotFound();
            }
            return View();
        }
        [HttpPost]
        public IActionResult Create(int projectId)
        {
            var project = _context.projects.Find(projectId);
            if (project == null)
            {
                return NotFound();

            }
            var task = new ProjectTask
            {
                ProjectId = projectId
            };

            return View();

        }
        public async Task<IActionResult> Search(int? projectId, string searchString)
        {
            var taskQuery = _context.tasks.AsQueryable();
            bool searchPerformed = !string.IsNullOrEmpty(searchString);

            if (projectId.HasValue)
            {
                taskQuery = taskQuery.Where(t => t.ProjectId == projectId);
            }

            if (searchPerformed)
            {
                taskQuery = taskQuery.Where(t => t.Title.Contains(searchString)
                                              || t.Description.Contains(searchString));
            }

            var tasks = await taskQuery.ToListAsync();
            ViewBag.ProjectId = projectId;
            ViewData["searchPerformed"] = searchPerformed;
            ViewData["searchString"] = searchString;

            return View("Index", tasks);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Title", "Description", "ProjectId")] ProjectTask task)
        {
            if (ModelState.IsValid)
            {
                _context.tasks.Add(task);
                _context.SaveChanges();
                return RedirectToAction("Index", new { task.ProjectId });
            }
            ViewBag.Projects = new SelectList(_context.projects, "ProjectId", "Name", task.ProjectId);
            return View(task);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var task = _context.tasks.Include(_t => _t.Project).FirstOrDefault(t => t.ProjectTaskId == id);
            if (task == null)
            {
                return NotFound();
            }
            ViewBag.Projects = new SelectList(_context.projects, "ProjectId", "Name", task.ProjectId);
            return View(task);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Edit(int id, [Bind("ProjectTaskId", "Title", "Description", "ProjectId")] ProjectTask task)
        {
            if (id != task.ProjectTaskId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _context.tasks.Update(task);
                _context.SaveChanges();
                return RedirectToAction("Index", new { task.ProjectId });
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var task = _context.tasks.Include(_t => _t.Project).FirstOrDefault(t => t.ProjectTaskId == id);
            if (task == null)
            {
                return NotFound();
            }
            ViewBag.Projects = new SelectList(_context.projects, "ProjectId", "Name", task.ProjectId);


            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult DeleteConfirmed(int projectTaskId)
        {
            var task = _context.tasks.Find(projectTaskId);
            if (task == null)
            {
                _context.tasks.Remove(task);
                _context.SaveChanges();
                return RedirectToAction("Index", new { task.ProjectId });
            }

            return NotFound();

        }

    }
}
