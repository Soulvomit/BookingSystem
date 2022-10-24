using BookingSystemDataLayer.Data;
using System.Data.Entity.Migrations;

namespace BookingSystemDataLayer.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<BookingDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "BookingSystemDataLayer.BookingDBContext";
        }

        protected override void Seed(BookingDBContext context)
        {
            context.Database.ExecuteSqlCommand("DELETE FROM Bookings");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT(Bookings, RESEED, 0)");
            context.Database.ExecuteSqlCommand("DELETE FROM Customers");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT(Customers, RESEED, 0)");
            context.Database.ExecuteSqlCommand("DELETE FROM Employees");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT(Employees, RESEED, 0)");

            context.Employees.AddOrUpdate(new Employee() { Firstname = "Jonas", Lastname = "Brown", Birthdate = new DateTime(1983, 9, 2) });
            context.Employees.AddOrUpdate(new Employee() { Firstname = "Line", Lastname = "Vandsted", Birthdate = new DateTime(1987, 9, 25) });
            context.Employees.AddOrUpdate(new Employee() { Firstname = "Ada-Noelle", Lastname = "Brown", Birthdate = new DateTime(2022, 1, 29, 12, 29, 00) });
            context.Employees.AddOrUpdate(new Employee() { Firstname = "Bertram", Lastname = "Brown", Birthdate = new DateTime(1983, 1, 29, 12, 27, 00) });

            context.Customers.AddOrUpdate(new Customer() { Firstname = "Oda", Lastname = "Blaa", Birthdate = new DateTime(1988, 10, 9) });
            context.Customers.AddOrUpdate(new Customer() { Firstname = "Sirus", Lastname = "Schou", Birthdate = new DateTime(2004, 4, 4) });
            context.Customers.AddOrUpdate(new Customer() { Firstname = "Kaya", Lastname = "Lomme", Birthdate = new DateTime(1938, 4, 27) });
            context.Customers.AddOrUpdate(new Customer() { Firstname = "Sol", Birthdate = new DateTime(1997, 2, 28) });

            context.SaveChanges();

            context.Bookings.AddOrUpdate(new Booking() { Customer = context.Customers.Where(c => c.Id == 1).First(), Employee = context.Employees.Where(e => e.Id == 1).First(), Date = new DateTime(2023, 2, 2), Start = new TimeSpan(13, 30, 0), End = new TimeSpan(14, 0, 0) });
            context.Bookings.AddOrUpdate(new Booking() { Customer = context.Customers.Where(c => c.Id == 2).First(), Employee = context.Employees.Where(e => e.Id == 1).First(), Date = new DateTime(2023, 3, 2), Start = new TimeSpan(9, 30, 0), End = new TimeSpan(11, 0, 0) });
            context.Bookings.AddOrUpdate(new Booking() { Customer = context.Customers.Where(c => c.Id == 3).First(), Employee = context.Employees.Where(e => e.Id == 2).First(), Date = new DateTime(2023, 10, 5), Start = new TimeSpan(6, 0, 0), End = new TimeSpan(14, 30, 0) });
            context.Bookings.AddOrUpdate(new Booking() { Customer = context.Customers.Where(c => c.Id == 4).First(), Employee = context.Employees.Where(e => e.Id == 2).First(), Date = new DateTime(2023, 8, 1), Start = new TimeSpan(8, 30, 0), End = new TimeSpan(10, 0, 0) });

            base.Seed(context);
        }
    }
}
