using BookingSystemDataLayer.Data;
using System.Collections.ObjectModel;

namespace BookingSystemDataLayer.Interfaces
{
    public interface IBookingStorage
    {
        public int CreateBooking(Booking booking);
        public Collection<Booking> GetBookingsForCustomer(int customerId);
    }
}
