using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestDB;
using TestDB.Models;

namespace TestAPIRest.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private TestContext _testContext;

        public ProductsController(TestContext testContext)
        {
            _testContext = testContext;
        }

        [HttpGet]
        public Task<List<Product>> GetProducts() => Task.FromResult(_testContext.Products.ToList());

        [HttpPost]
        public Task<bool> InsertProduct(Product newProduct)
        {
            try
            {
                _testContext.Products.Add(newProduct);
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
