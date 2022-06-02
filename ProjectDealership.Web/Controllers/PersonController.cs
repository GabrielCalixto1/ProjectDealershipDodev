using ProjectDealership.Web.DTOs;
using Microsoft.AspNetCore.Mvc;
using ProjectDeleaship.Lib.Models;

namespace ProjectDealership.Web.Controllers
{
   [ApiController]
    [Route("Controller")]
    public class PersonController : ControllerBase
    {
        public static List<PersonDTO> Persons { get; set; } = new List<PersonDTO>();

        [HttpPost]
        public IActionResult SetPerson(PersonDTO personsDto)
        {     
            var person = new Person(personsDto.Name, personsDto.Cpf, personsDto.Birthdate);   
            Persons.Add(personsDto);      
            return Ok(Persons);
        }
        [HttpGet]
        public IActionResult GetPerson()
        {
            return Ok(Persons);
        }
        [HttpDelete]
        public IActionResult DeletePerson()
          {                     
            var CountPersons = Persons.Count<PersonDTO>();
            Persons.RemoveAt(CountPersons-1);
            return Ok(Persons);
        } 
    } 
}