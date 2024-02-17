using Microsoft.EntityFrameworkCore;
using COMP2139_Labs.Models;

namespace COMP2139_Labs.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Project> projects { get; set; }
        public DbSet<ProjectTask> tasks { get; set; }




    }
}
