using Day26Concepts.Models;
using Day26Concepts.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day26Concepts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LifeTimeController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly IProductRepository _productRepository1;

        public LifeTimeController(IProductRepository productRepository, IProductRepository productRepository1)
        {
            _productRepository = productRepository;
            _productRepository1 = productRepository1;
        }

        //SingleTon Srevice
        [HttpPost("")]
        public IActionResult AddProduct([FromBody] ProductModel product)
        {
            _productRepository.AddProduct(product);
            var products = _productRepository1.GetAllProducts();

            return Ok(products);
        }

        //Scoped Service
        [HttpPost("")]
        public IActionResult AddOneProduct([FromBody] ProductModel product)
        {
            _productRepository.AddProduct(product);
            var products = _productRepository1.GetAllProducts();

            return Ok(products);
        }

        //Transient Service
        [HttpPost("")]
        public IActionResult AddAnotherProduct([FromBody] ProductModel product)
        {
            _productRepository.AddProduct(product);
            var products = _productRepository1.GetAllProducts();

            return Ok(products);
        }
    }
}
