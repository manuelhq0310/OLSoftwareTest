using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using TestDB;
using TestDB.Models;

namespace TestAPIRest.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private TestContext _testContext;

        public ClientsController(TestContext testContext)
        {
            _testContext = testContext;
        }

        [HttpGet]
        public Task<List<Person>> GetClients() => Task.FromResult(_testContext.People.ToList());

        [HttpPost]
        public Task<bool> InsertClient(Person newPerson)
        {
            try
            {
                _testContext.People.Add(newPerson);
                _testContext.SaveChanges();
                return Task.FromResult(true);
            }
            catch (Exception)
            {
                return Task.FromResult(false);
            }
        }
    }
}
