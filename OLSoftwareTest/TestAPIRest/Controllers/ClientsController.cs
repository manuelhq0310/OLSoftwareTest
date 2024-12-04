using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using TestAPIRest.Services;
using TestDB;
using TestDB.Models;

namespace TestAPIRest.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly ClientService _clientService;

        public ClientsController(ClientService clientService)
        {            
            _clientService = clientService;
        }

        [HttpGet]
        public Task<List<Person>> GetClients() => _clientService.GetClients();

        [HttpPost]
        public Task<bool> InsertClient(Person newPerson) => _clientService.InsertClient(newPerson);
    }
}
