using ProjectDealership.Web.DTOs;
using Microsoft.AspNetCore.Mvc;
using ProjectDealership.Models;

namespace ProjectDealership.Web.Controllers
{
   [ApiController]
    [Route("Controller")]
    public class SaleController : ControllerBase
    {
        public static List<SaleDTO> Sales { get; set; } = new List<SaleDTO>();

        [HttpPost]
        public IActionResult SetSale(SaleDTO saleDto)
        {   
            var sale = new Sale(saleDto.Buyer, saleDto.Seller, saleDto.Vehicle, saleDto.PaymentMethod, saleDto.FinalAmount);     
            Sales.Add(saleDto);      
            return Ok(Sales);
        }
        [HttpGet]
        public IActionResult GetSale()
        {
            return Ok(Sales);
        }
        [HttpDelete]
        public IActionResult DeleteSale()
        {                     
            var CountSales = Sales.Count<SaleDTO>();
            Sales.RemoveAt(CountSales-1);
            return Ok(Sales);
        }    
    } 
}