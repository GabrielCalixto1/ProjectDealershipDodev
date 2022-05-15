using Microsoft.AspNetCore.Mvc;
using ProjectDealership.Models;

namespace ProjectDealership.Web.Controllers
{
   [ApiController]
    [Route("Controller")]
    public class EmployeeController : ControllerBase
    {
        public static List<Employee> Employees { get; set; } = new List<Employee>();

        [HttpPost]
        public IActionResult SetEmployee(Employee employee)
        {        
            Employees.Add(employee);      
            return Ok(Employees);
        }
        [HttpGet]
        public IActionResult GetEmployee()
        {
            return Ok(Employees);
        }
        [HttpDelete]
        public IActionResult DeleteEmployee()
        {                     
            var CountEmployees = Employees.Count<Employee>();
            Employees.RemoveAt(CountEmployees -1);
            return Ok(Employees);
        }  
    } 
}