using ServerApp.Models;
using System.Collections;

namespace ServerApp.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
        IList GetEmployeeByTotalHours();
    }
}
