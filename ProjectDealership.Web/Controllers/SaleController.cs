using Microsoft.AspNetCore.Mvc;
using ProjectDealership.Models;

namespace ProjectDealership.Web.Controllers
{
   [ApiController]
    [Route("Controller")]
    public class SaleController : ControllerBase
    {
        public static List<Sale> Sales { get; set; } = new List<Sale>();

        [HttpPost]
        public IActionResult SetSale(Sale sale)
        {        
            Sales.Add(sale);      
            return Ok(Sales);
        }
        [HttpGet]
        public IActionResult GetSale()
        {
            return Ok(Sales);
        }
        [HttpDelete]
        public IActionResult DeleteSale(int WhatListPosition)
        {
           
         Sales.RemoveAt(WhatListPosition); //Testing the removes
         
            return Ok();
        }      
    } 
}