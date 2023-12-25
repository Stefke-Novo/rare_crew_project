using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using ServerApp.Models;
using ServerApp.Services;

namespace ServerApp.Controllers
{
    [EnableCors("MySpecificOrigins")]
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _EmployeeService;
        public EmployeeController(IEmployeeService employeeService) {
            _EmployeeService = employeeService;
        }
        [HttpGet]
        public ActionResult<IList<Object>> GetAllByTotalHoursWorked()
        {
            return Ok(_EmployeeService.GetEmployeeByTotalHours());
        }
    }
}
