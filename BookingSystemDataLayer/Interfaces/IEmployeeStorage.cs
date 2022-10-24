using BookingSystemDataLayer.Data;
using System.Collections.ObjectModel;

namespace BookingSystemDataLayer.Interfaces
{
    public interface IEmployeeStorage
    {
        public int CreateEmployee(Employee employee);
        public Collection<Employee> GetEmployeeWithId(int employeeId);
    }
}
