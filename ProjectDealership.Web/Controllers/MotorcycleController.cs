using Microsoft.AspNetCore.Mvc;
using ProjectDealership.Models;

namespace ProjectDealership.Web.Controllers
{
   [ApiController]
    [Route("Controller")]
    public class MotorcycleController : ControllerBase
    {
        public static List<Motorcycle> Motorcycles { get; set; } = new List<Motorcycle>();

        [HttpPost]
        public IActionResult SetMotorcycle(Motorcycle motorcycle)
        {        
            Motorcycles.Add(motorcycle);      
            return Ok(Motorcycles);
        }
        [HttpGet]
        public IActionResult GetMotorcycle()
        {
            return Ok(Motorcycles);
        }
        [HttpDelete]
        public IActionResult DeleteMotorcycle()
         {                     
            var CountMotorcycles = Motorcycles.Count<Motorcycle>();
            Motorcycles.RemoveAt(CountMotorcycles-1);
            return Ok(Motorcycles);
        }    
    } 
}