using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestAPIRest.Services;
using TestDB;
using TestDB.Models;

namespace TestAPIRest.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductsController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public Task<List<Product>> GetProducts() => _productService.GetProducts();

        [HttpPost]
        public Task<bool> InsertProduct(Product newProduct) => _productService.InsertProduct(newProduct);        
    }
}
