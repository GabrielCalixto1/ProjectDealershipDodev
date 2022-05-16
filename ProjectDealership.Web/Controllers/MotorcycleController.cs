using ProjectDealership.Web.DTOs;
using Microsoft.AspNetCore.Mvc;
using ProjectDealership.Models;

namespace ProjectDealership.Web.Controllers
{
   [ApiController]
    [Route("Controller")]
    public class MotorcycleController : ControllerBase
    {
        public static List<MotorcycleDTO> Motorcycles { get; set; } = new List<MotorcycleDTO>();

        [HttpPost]
        public IActionResult SetMotorcycle(MotorcycleDTO motorcycleDto)
        {  
            var motorcycle = new Motorcycle(motorcycleDto.Cylinders, motorcycleDto.Departure, motorcycleDto.Brand, 
            motorcycleDto.Model, motorcycleDto.Year, motorcycleDto.Mileage, motorcycleDto.Color, motorcycleDto.Price);     
            Motorcycles.Add(motorcycleDto);      
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
            var CountMotorcycles = Motorcycles.Count<MotorcycleDTO>();
            Motorcycles.RemoveAt(CountMotorcycles-1);
            return Ok(Motorcycles);
        }    
    } 
}