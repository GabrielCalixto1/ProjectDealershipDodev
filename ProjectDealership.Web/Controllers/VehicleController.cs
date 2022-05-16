using ProjectDealership.Web.DTOs;
using Microsoft.AspNetCore.Mvc;
using ProjectDealership.Models;

namespace ProjectDealership.Web.Controllers
{
    [ApiController]
    [Route("Controller")]
    public class VehicleController : ControllerBase
    {
        public static List<VehicleDTO> Vehicles { get; set; } = new List<VehicleDTO>();

        [HttpPost]
        public IActionResult SetVehicle(VehicleDTO vehicleDto)
        {
            try
            {
                var vehicle = new Vehicle(vehicleDto.Brand, vehicleDto.Model, vehicleDto.Year, vehicleDto.Mileage, vehicleDto.Color, vehicleDto.Price);
                Vehicles.Add(vehicleDto);
                return Ok(Vehicles);
            }
            catch
            {
                return BadRequest("Ocorreu um erro");
            }
        }
        [HttpGet]
        public IActionResult GetVehicle()
        {
            return Ok(Vehicles);
        }
        [HttpDelete]
        public IActionResult DeleteVehicle()
        {
            var CountVehicles = Vehicles.Count<VehicleDTO>();
            Vehicles.RemoveAt(CountVehicles - 1);
            return Ok(Vehicles);
        }
        [HttpGet("Price")]
        public IActionResult SetPrice(double price)
        {
            try
            {
                var vehicle = new Vehicle("a", "a", DateTime.Today, 0, "red", price);
                return Ok(vehicle.GetPrice);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}