using Microsoft.AspNetCore.Mvc;
using TestDB;
using TestDB.Models;

namespace TestAPIRest.Services
{
    public class ProductService
    {
        private readonly TestContext _testContext;

        public ProductService(TestContext testContext)
        {
            _testContext = testContext;
        }

        public Task<List<Product>> GetProducts() => Task.FromResult(_testContext.Products.ToList());

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
