using ProjectDealership.Web.DTOs;
using Microsoft.AspNetCore.Mvc;
using ProjectDeleaship.Lib.Models;

namespace ProjectDealership.Web.Controllers
{
   [ApiController]
    [Route("Controller")]
    public class EmployeeController : ControllerBase
    {
        public static List<EmployeeDTO> Employees { get; set; } = new List<EmployeeDTO>();

        [HttpPost]
        public IActionResult SetEmployee(EmployeeDTO employeeDto)
        {    
            var employee = new Employee(employeeDto.Position, employeeDto.Name, employeeDto.Cpf, employeeDto.Birthdate);   
            Employees.Add(employeeDto);      
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
            var CountEmployees = Employees.Count<EmployeeDTO>();
            Employees.RemoveAt(CountEmployees -1);
            return Ok(Employees);
        }  
    } 
}