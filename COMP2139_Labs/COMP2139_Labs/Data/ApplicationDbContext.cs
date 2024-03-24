
using Microsoft.EntityFrameworkCore;
using COMP2139_Labs.Areas.ProjectManagement.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace COMP2139_Labs.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Project> projects { get; set; }
        public DbSet<ProjectTask>? tasks { get; set; }
        public DbSet<ProjectComment> comments { get; set; }

	}
}
