using Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Car> cars { get; set; }
        public DbSet<Hotel> hotels { get; set; }
        public DbSet<Flight> flights { get; set; }
        public DbSet<Booking> bookings { get; set; }






    }
}
