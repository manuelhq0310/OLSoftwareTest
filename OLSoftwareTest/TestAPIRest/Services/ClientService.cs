using TestDB;
using TestDB.Models;

namespace TestAPIRest.Services
{
    public class ClientService
    {
        private readonly TestContext _testContext;

        public ClientService(TestContext testContext)
        {
            _testContext = testContext;
        }

        public Task<List<Person>> GetClients() => Task.FromResult(_testContext.People.ToList());

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
