using Microsoft.AspNetCore.Mvc;
using ProjectDealership.Models;

namespace ProjectDealership.Web.Controllers
{
   [ApiController]
    [Route("Controller")]
    public class ClientController : ControllerBase
    {
        public static List<Client> Clients { get; set; } = new List<Client>();

        [HttpPost]
        public IActionResult SetClient(Client client)
        {        
            Clients.Add(client);      
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
            var CountClients = Clients.Count<Client>();
            Clients.RemoveAt(CountClients -1);
            return Ok(Clients);
        }     
    } 
}