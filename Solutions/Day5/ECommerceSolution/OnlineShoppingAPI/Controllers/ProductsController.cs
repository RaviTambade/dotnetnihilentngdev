using Microsoft.AspNetCore.Mvc;
using OnlineShoppingAPI.Entities;
using OnlineShoppingAPI.Repositories;
using OnlineShoppingAPI.Services;

namespace OnlineShoppingAPI.Controllers
{

    //Attributes
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
 

        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        // Action method to get weather forecasts
        // Action Listener
        [HttpGet]
        public IEnumerable<Product> Get()
        {

            IProductRepository productRepository = new ProductRepository();
            IProductService productService = new ProductService(productRepository);
            return productService.GetAllProducts();

        }
    }
}
