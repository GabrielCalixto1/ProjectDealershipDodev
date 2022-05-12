using Microsoft.AspNetCore.Mvc;
using ProjectDealership.Models;

namespace ProjectDealership.Web.Controllers
{
   [ApiController]
    [Route("Controller")]
    public class CarController : ControllerBase
    {
        public static List<Car> Cars { get; set; } = new List<Car>();

        [HttpPost]
        public IActionResult SetCar(Car car)
        {        
            Cars.Add(car);      
            return Ok(Cars);
        }
        [HttpGet]
        public IActionResult GetCar()
        {
            return Ok(Cars);
        }
        [HttpDelete]
        public IActionResult DeleteCar(int WhatListPosition)
        {
           
         Cars.RemoveAt(WhatListPosition); //Testing the removes
         
            return Ok();
        }      
    } 
}