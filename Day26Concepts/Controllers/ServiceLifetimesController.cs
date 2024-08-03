﻿using Day26Concepts.Models;
using Day26Concepts.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day26Concepts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceLifetimesController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly IProductRepository _productRepository1;

        public ServiceLifetimesController(IProductRepository productRepository, IProductRepository productRepository1)
        {
            _productRepository = productRepository;
            _productRepository1 = productRepository1;
        }

        [HttpGet("")]
        public IActionResult GetName()
        {
            var name = _productRepository.GetName();

            return Ok(name);
        }
    }
}
