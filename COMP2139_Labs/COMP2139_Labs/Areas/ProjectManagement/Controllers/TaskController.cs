using COMP2139_Labs.Areas.ProjectManagement.Models;
using COMP2139_Labs.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Threading.Tasks;

namespace COMP2139_Labs.Areas.ProjectManagement.Controllers
{
    [Area("ProjectManagement")]
    [Route("[area]/[controller]/[action]")]

    public class TaskController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TaskController(ApplicationDbContext context)
        {
            _context = context;
        }



        [HttpGet("Index/{projectId:int?}")]
        public async Task<IActionResult> Index(int? projectId)
        {
            var taskQuery = _context.tasks.AsQueryable();

            if (projectId.HasValue)
            {
                taskQuery = taskQuery.Where(t => t.ProjectId == projectId.Value);
            }
            var tasks = await taskQuery.ToListAsync();
            ViewBag.ProjectId = projectId;
            return View(tasks);
        }

        [HttpGet("Details/{id:int}")]

        public async Task<IActionResult> Details(int id)
        {
            var task = await _context.tasks
                                     .Include(t => t.Project)
                                     .FirstOrDefaultAsync(t => t.ProjectTaskId == id);

            if (task == null)
            {
                return NotFound();
            }
            return View(task);

        }


        [HttpGet("Create/{projectId:int}")]
        public async Task<IActionResult> Create(int projectId)
        {
            var project = await _context.projects.FindAsync(projectId);
            if (project == null)
            {
                return NotFound();
            }

            var task = new ProjectTask
            {
                ProjectId = projectId
            };

            return View(task);

        }


        [HttpPost("Create/{projectId:int}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title", "Description", "ProjectId")] ProjectTask task)
        {
            if (ModelState.IsValid)
            {
                await _context.tasks.AddAsync(task);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index), new { projectId = task.ProjectId });
            }

            var projects = await _context.tasks.ToListAsync();

            ViewBag.Projects = new SelectList(projects, "ProjectId", "Name", task.ProjectId);
            return View(task);

        }

        [HttpGet("Edit/{id:int}")]

        public async Task<IActionResult> Edit(int id)
        {
            var task = await _context.tasks
                                     .Include(t => t.Project)
                                     .FirstOrDefaultAsync(t => t.ProjectTaskId == id);

            if (task == null)
            {
                return NotFound();
            }

            var projects = await _context.projects.ToListAsync();

            ViewBag.Projects = new SelectList(projects, "ProjectId", "Name", task.ProjectId);
            return View(task);

        }



        [HttpPost("Edit/{id:int}")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(int id, [Bind("ProjectTaskId", "Title", "Description", "ProjectId")] ProjectTask task)
        {
            if (id != task.ProjectTaskId)
            {
                return NotFound();
            }


            if (ModelState.IsValid)
            {
                _context.Update(task);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), new { projectId = task.ProjectId });

            }

            var projects = await _context.projects.ToListAsync();

            ViewBag.Projects = new SelectList(projects, "ProjectId", "Name", task.ProjectId);
            return View(task);


        }












    }
}
