using ProjectDealership.Web.DTOs;
using Microsoft.AspNetCore.Mvc;
using ProjectDeleaship.Lib.Models;

namespace ProjectDealership.Web.Controllers
{
    [ApiController]
    [Route("Controller")]
    public class ClientController : ControllerBase
    {
        public static List<ClientDTO> Clients { get; set; } = new List<ClientDTO>();

        [HttpPost]
        public IActionResult SetClient(ClientDTO clientDto)
        {
            var client = new Client(clientDto.Email, clientDto.Name, clientDto.Cpf, clientDto.Birthdate, clientDto.Telephone);
            Clients.Add(clientDto);
            return Ok(Clients);
        }
        [HttpGet]
        public IActionResult GetClient()
        {
            return Ok(Clients);
        }
        [HttpDelete]
        public IActionResult DeleteClient()
        {
            var CountClients = Clients.Count<ClientDTO>();
            Clients.RemoveAt(CountClients - 1);
            return Ok(Clients);
        }
        public IActionResult SetTelephone(string telephone)
        {
            try
            {
                var client = new Client("a", "a", "a", DateTime.Today, telephone);
                return Ok(client.GetTelephone);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        public IActionResult SetEmail(string email)
        {
            try
            {
                var client = new Client(email, "a", "515", DateTime.Today, "telephone");
                return Ok(client.GetEmail);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}