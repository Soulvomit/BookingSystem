using BookingSystemDataLayer.Data;

namespace BookingSystemService.Interfaces
{
    public interface IEmployeeService
    {
        public int CreateEmployee(Employee employee);
        public Employee GetEmployeeById(int employeeId);
    }
}
