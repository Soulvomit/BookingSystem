using BookingSystemDataLayer.Data;
using System.Collections.ObjectModel;

namespace BookingSystemService.Interfaces
{
    public interface IBookingService
    {
        public int CreateBooking(int customerId, int employeeId, DateTime date, TimeSpan start, TimeSpan end);
        public Collection<Booking> GetBookingsForCustomer(int customerId);
        public Collection<Booking> GetBookingsForEmployee(int employeeId);
    }
}
