using BookingSystemDataLayer.Data;
using BookingSystemDataLayer.Interfaces;
using System.Collections.ObjectModel;
using System.Data.Entity.Migrations;

namespace BookingSystemDataLayer.Concrete
{
    public class BookingStorage : IBookingStorage
    {
        public int CreateBooking(Booking booking)
        {
            using (BookingDBContext context = new BookingDBContext())
            {
                context.Bookings.Add(booking);
                context.SaveChanges(); 
                return booking.Id;
            }
        }

        public Collection<Booking> GetBookingsForCustomer(int customerId)
        {
            using (BookingDBContext context = new BookingDBContext())
            {
                return new Collection<Booking>(context.Bookings.Where<Booking>(b => b.Customer.Id == customerId).ToList<Booking>());
            }
        }
    }
}
