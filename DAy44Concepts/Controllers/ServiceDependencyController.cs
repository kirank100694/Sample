﻿using DAy44Concepts.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DAy44Concepts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceDependencyController : ControllerBase
    {
        public IEnumerable<EmployeeModel> GetEmployees()
        {
            return new List<EmployeeModel>() {
                new EmployeeModel() { Id = 1, Name = "Employee 1 " },
                new EmployeeModel() { Id = 2, Name = "Employee 2 " }
            };
        }

        [Route("{Id}")]
        public IActionResult GetEmployees(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            return Ok(new List<EmployeeModel>() {
                new EmployeeModel() { Id = 1, Name = "Employee 1 " },
                new EmployeeModel() { Id = 2, Name = "Employee 2 " }
            });
        }

        [Route("{Id}/basic")]
        public ActionResult<EmployeeModel> GetEmployeeBasicDetails(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            return new EmployeeModel() { Id = 1, Name = "Employee 1 " };
        }

        [HttpGet("name")]
        public IActionResult GetName([FromServices] IProductRepository _productRepository)
        {
            var name = _productRepository.GetName();
            return Ok(name);
        }
    }
}
