using BookingSystemDataLayer.Concrete;
using BookingSystemDataLayer.Data;
using BookingSystemService.Interfaces;
using System.Collections.ObjectModel;

namespace BookingSystemService.Concrete
{
    public class BookingService : IBookingService
    {
        private BookingStorage bookingStorage { get; set; } 

        public BookingService()
        {
            this.bookingStorage = new BookingStorage();
        }

        public int CreateBooking(int customerId, int employeeId, DateTime date, TimeSpan start, TimeSpan end)
        {
            Booking b = new Booking() { Customer = new Customer() { Id = customerId }, Employee = new Employee { Id = employeeId }, Date = date, Start = start, End = end };
            bookingStorage.CreateBooking(b);
            return b.Id;
        }

        public Collection<Booking> GetBookingsForCustomer(int customerId)
        {
            return bookingStorage.GetBookingsForCustomer(customerId);
        }

        public Collection<Booking> GetBookingsForEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }
    }
}
