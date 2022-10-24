using BookingSystemDataLayer;
using BookingSystemDataLayer.Concrete;
using BookingSystemDataLayer.Data;
using BookingSystemDataLayer.Interfaces;
using Moq;

namespace BookingSystemUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        { 
            BookingDBContext context = new BookingDBContext();
            Booking b = new Booking { Customer = context.Customers.Where(c => c.Id == 1).First(), Employee = context.Employees.Where(e => e.Id == 1).First(), Date = DateTime.Now, Start = new TimeSpan(1,1,30), End = new TimeSpan(9,8,30) };
            BookingStorage bs = new BookingStorage();

            int i = bs.CreateBooking(b);

            Assert.IsTrue(i > 0);
        }
    }
}