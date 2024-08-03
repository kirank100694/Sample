using Day26Concepts.Models;
using Day26Concepts.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day26Concepts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InjectionController : ControllerBase
    {
        private readonly ProductRepository _productRepository;

        public InjectionController()
        {
            _productRepository = new ProductRepository();
        }

        [HttpPost("")]
        public IActionResult AddProduct([FromBody]ProductModel product)
        {
            _productRepository.AddProduct(product);
            var products = _productRepository.GetAllProducts();

            return Ok(products);
        }
    }
}
