using Day25Concepts.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Day25Concepts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
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
    }
}
