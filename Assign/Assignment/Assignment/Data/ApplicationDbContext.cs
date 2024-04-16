using Assignment.Areas.BookingManagement.Models;
using Assignment.Areas.ServiceManagement.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Car> cars { get; set; }
        public DbSet<Hotel> hotels { get; set; }
        public DbSet<Flight> flights { get; set; }
        public DbSet<Booking> bookings { get; set; }
        public DbSet<CarBooking> cBookings { get; set; }

        public DbSet<FlightBooking> fBookings { get; set; }
        public DbSet<HotelBooking> hBookings { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Car>().HasData(
                new Car
                {
                    id = 1,
                    model = "Kawasaki Ninja",
                    type = "Sports Bike",
                    price = 150,
                    rentalCompanies = "BikeGo",
                    location = "Toronto",
                    isAvailable = true,
                    availableFrom = new DateTime(2024, 4, 15)
                }
                );
            List<string> cities = new List<string> { "New York", "Los Angeles", "Chicago", "Houston", "Phoenix", "Philadelphia", "San Antonio", "San Diego", "Dallas", "San Jose" };
            List<string> carModels = new List<string> { "Toyota Corolla", "Honda Civic", "Ford Fusion", "Chevrolet Malibu", "Toyota Camry", "Honda Accord", "Nissan Altima", "Hyundai Elantra", "Kia Forte", "Volkswagen Jetta" };

            Random rand = new Random();

            // Generate additional 20 data entries
            for (int i = 2; i <= 21; i++) // Start from 2 because 1 is already inserted
            {
                builder.Entity<Car>().HasData(
                    new Car
                    {
                        id = i,
                        model = carModels[rand.Next(carModels.Count)], // Random car model
                        type = "Sports Car", // Assuming they are all sports cars
                        price = rand.Next(50, 300), // Random price between 50 and 300
                        rentalCompanies = "Rental" + i,
                        location = cities[rand.Next(cities.Count)], // Random city
                        isAvailable = rand.Next(0, 2) == 0 ? false : true, // Random availability
                        availableFrom = new DateTime(2024, 4, rand.Next(1, 30)) // Random day in April 2024
                    }
                );
            }
                builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    id = 1,
                    name = "Rolex Hotel",
                    city = "Toronto",
                    location = "219 Dundas St. East, Toronto, ON M5A 0V1",
                    price = 120,
                    numRooms = 30,
                    amenities = "Heater, Balcony, TV, Free Breakfast"
                }
                );
                List<string> hotelNames = new List<string> { "Marriott", "Hilton", "Hyatt", "Sheraton", "Holiday Inn", "Radisson", "Wyndham", "Four Seasons", "Ritz-Carlton", "InterContinental" };


            // Generate additional 20 data entries
            for (int i = 2; i <= 21; i++) // Start from 2 because 1 is already inserted
            {
                builder.Entity<Hotel>().HasData(
                    new Hotel
                    {
                        id = i,
                        name = hotelNames[rand.Next(hotelNames.Count)], // Random hotel name
                        city = cities[rand.Next(cities.Count)], // Random city
                        location = $"{rand.Next(1, 1000)} {hotelNames[rand.Next(hotelNames.Count)]} St., {cities[rand.Next(cities.Count)]}, {rand.Next(10000, 99999)}", // Random location
                        price = rand.Next(80, 300), // Random price between 80 and 300
                        numRooms = rand.Next(20, 100), // Random number of rooms between 20 and 100
                        amenities = "Wi-Fi, Air Conditioning, TV, Swimming Pool" // Assuming common amenities
                    }
                );
            }
                    builder.Entity<Flight>().HasData(
                    new Flight
                    {
                        id = 1,
                        departure = "YYZ",
                        arrival = "DXB",
                        depTime = new DateTime(2024, 04, 24, 18, 30, 0),
                        arrTime = new DateTime(2024, 04, 25, 7, 20, 0),
                        airline = "Emirates",
                        price = 700,
                        numPassanger = 30,
                        maxPassanger = 276,
                    }
                    );
            List<string> departureCodes = new List<string> { "YYZ", "LAX", "JFK", "LHR", "CDG", "SFO", "HND", "DFW", "ATL", "PEK" };
            List<string> arrivalCodes = new List<string> { "DXB", "LHR", "JFK", "CDG", "AMS", "HKG", "FRA", "ICN", "SIN", "CAN" };
            // Real airline names
            List<string> airlines = new List<string> { "Emirates", "Delta Air Lines", "American Airlines", "United Airlines", "Lufthansa", "British Airways", "Qantas", "Air Canada", "Singapore Airlines", "Cathay Pacific" };


            // Generate additional 20 data entries
            for (int i = 2; i <= 21; i++) // Start from 2 because 1 is already inserted
            {
                builder.Entity<Flight>().HasData(
                    new Flight
                    {
                        id = i,
                        departure = departureCodes[rand.Next(departureCodes.Count)], // Random departure code
                        arrival = arrivalCodes[rand.Next(arrivalCodes.Count)], // Random arrival code
                        depTime = DateTime.Now.AddDays(rand.Next(1, 30)).AddHours(rand.Next(1, 24)).AddMinutes(rand.Next(1, 60)), // Random departure time within the next 30 days
                        arrTime = DateTime.Now.AddDays(rand.Next(1, 30)).AddHours(rand.Next(1, 24)).AddMinutes(rand.Next(1, 60)), // Random arrival time within the next 30 days
                        airline = airlines[rand.Next(airlines.Count)], // Random airline
                        price = rand.Next(300, 1500), // Random price between 300 and 1500
                        numPassanger = rand.Next(10, 200), // Random number of passengers between 10 and 200
                        maxPassanger = rand.Next(200, 500) // Random maximum number of passengers between 200 and 500
                    }
                );
            }


            base.OnModelCreating(builder);

                builder.HasDefaultSchema("Identity");
                builder.Entity<ApplicationUser>(entity =>
                {
                    entity.ToTable(name: "User");
                });

                builder.Entity<IdentityRole>(entity =>
                {
                    entity.ToTable(name: "Role");
                });

                builder.Entity<IdentityUserRole<string>>(entity =>

                {
                    entity.ToTable(name: "UserRoles");

                });

                builder.Entity<IdentityUserClaim<string>>(entity =>
                {
                    entity.ToTable(name: "UserClaims");
                });

                builder.Entity<IdentityUserLogin<string>>(entity =>
                {
                    entity.ToTable(name: "UserLogins");
                });

                builder.Entity<IdentityRoleClaim<string>>(entity =>
                {
                    entity.ToTable(name: "RoleClaims");
                });

            builder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable(name: "UserTokens");
            });
        }
    }
}

