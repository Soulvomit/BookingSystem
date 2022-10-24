using BookingSystemDataLayer.Data;
using BookingSystemDataLayer.Migrations;
using System.Data.Entity;

namespace BookingSystemDataLayer
{
    public class BookingDBContext : DbContext
    {
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public BookingDBContext() : base()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BookingDBContext, Configuration>());
        }
        public static bool CreateDatabase()
        {
            using (BookingDBContext context = new BookingDBContext())
            {
                //Gaurd if database already exists
                //if (context.Database.Exists()) return false;
                
                context.Database.Initialize(true);
                return true;
            }
        }
    }
}
