using ProjectDealership.Web.DTOs;
using Microsoft.AspNetCore.Mvc;
using ProjectDeleaship.Lib.Models;
using System;
namespace ProjectDealership.Web.Controllers
{
    [ApiController]
    [Route("Controller")]
    public class CarController : ControllerBase
    {
        public static List<CarDTO> Cars { get; set; } = new List<CarDTO>();
        [HttpPost]
        public IActionResult SetCar(CarDTO carDto)
        {
            var car = new Car(carDto.AutomaticTransmission, carDto.Fuel, carDto.Brand, carDto.Model,
            carDto.Year, carDto.Mileage, carDto.Color, carDto.Price);
            Cars.Add(carDto);
            return Ok(Cars);
        }
        [HttpGet]
        public IActionResult GetCar()
        {
            return Ok(Cars);
        }
        [HttpDelete]
        public IActionResult DeleteCar()
        {                     
            var CountCars = Cars.Count<CarDTO>();
            Cars.RemoveAt(CountCars-1);
            return Ok(Cars);
        }
    }
}