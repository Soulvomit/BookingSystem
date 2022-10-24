using BookingSystemDataLayer.Data;
using BookingSystemDataLayer.Interfaces;
using System.Collections.ObjectModel;
using System.Data.Entity.Migrations;

namespace BookingSystemDataLayer.Concrete
{
    public class EmployeeStorage : IEmployeeStorage
    {
        public int CreateEmployee(Employee employee)
        {
            using (BookingDBContext context = new BookingDBContext())
            {
                context.Employees.AddOrUpdate(employee);
                context.SaveChanges();
                return employee.Id;
            }
        }

        public Collection<Employee> GetEmployeeWithId(int employeeId)
        {
            using (BookingDBContext context = new BookingDBContext())
            {
                return new Collection<Employee>(context.Employees.Where<Employee>(e => e.Id == employeeId).ToList<Employee>());
            }
        }
    }
}
