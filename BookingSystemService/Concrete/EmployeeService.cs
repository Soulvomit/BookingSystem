using BookingSystemDataLayer.Concrete;
using BookingSystemDataLayer.Data;
using BookingSystemService.Interfaces;

namespace BookingSystemService.Concrete
{
    public class EmployeeService : IEmployeeService
    {
        private EmployeeStorage employeeStorage { get; set; }

        public EmployeeService()
        {
            this.employeeStorage = new EmployeeStorage();
        }
        public int CreateEmployee(Employee employee)
        {
            employeeStorage.CreateEmployee(employee);
            return employee.Id;
        }
        public Employee GetEmployeeById(int employeeId)
        {
            return employeeStorage.GetEmployeeWithId(employeeId).First();
        }
    }
}
