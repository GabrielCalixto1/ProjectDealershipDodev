using Microsoft.AspNetCore.Mvc;
using ProjectDealership.Models;

namespace ProjectDealership.Web.Controllers
{
   [ApiController]
    [Route("Controller")]
    public class VehicleController : ControllerBase
    {
        public static List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();

        [HttpPost]
        public IActionResult SetVehicle(Vehicle vehicle)
        {        
            Vehicles.Add(vehicle);      
            return Ok(Vehicles);
        }
        [HttpGet]
        public IActionResult GetVehicle()
        {
            return Ok(Vehicles);
        }
        [HttpDelete]
        public IActionResult DeleteVehicle()
        {                     
            var CountVehicles = Vehicles.Count<Vehicle>();
            Vehicles.RemoveAt(CountVehicles-1);
            return Ok(Vehicles);
        }      
    } 
}