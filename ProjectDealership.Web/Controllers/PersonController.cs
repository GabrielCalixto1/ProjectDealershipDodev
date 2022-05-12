using Microsoft.AspNetCore.Mvc;
using ProjectDealership.Models;

namespace ProjectDealership.Web.Controllers
{
   [ApiController]
    [Route("Controller")]
    public class PersonController : ControllerBase
    {
        public static List<Person> Persons { get; set; } = new List<Person>();

        [HttpPost]
        public IActionResult SetPerson(Person persons)
        {        
            Persons.Add(persons);      
            return Ok(Persons);
        }
        [HttpGet]
        public IActionResult GetPerson()
        {
            return Ok(Persons);
        }
        [HttpDelete]
        public IActionResult DeletePerson(int WhatListPosition)
        {
           
         Persons.RemoveAt(WhatListPosition); //Testing the removes
         
            return Ok();
        }      
    } 
}