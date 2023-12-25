using Microsoft.IdentityModel.Tokens;
using ServerApp.Models;
using System.Collections;

namespace ServerApp.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly DBContext _DbContext;
        public EmployeeService(DBContext DbContext)
        {
            this._DbContext = DbContext;
        }

        public List<Employee> GetAll()
        {
            return _DbContext.Employees.ToList();
        }
        public IList GetEmployeeByTotalHours()
        {
            return (from employee in this._DbContext.Employees
                    where employee.Name!=null & employee.HoursWorked>0
                    group employee by employee.Name into person
                    orderby person.Sum(p => p.HoursWorked) descending
                    select new { Name = person.First().Name, TotalHoursWorked = person.Sum(p => p.HoursWorked) }).ToList();
        }
    }
}
