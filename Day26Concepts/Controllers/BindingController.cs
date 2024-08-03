using Day26Concepts.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day26Concepts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[BindProperties(SupportsGet = true)]
    public class BindingController : ControllerBase
    {
        //Bind Proprty and Properties
        [BindProperty(SupportsGet = true)]
        public CountryModel Country { get; set; }

        [HttpGet("")]
        public IActionResult AddCountry()
        {
            return Ok($"Name = {this.Country.Name}," + $"Population = {this.Country.Population}," + $"Area = {this.Country.Area}");
        }

        [HttpGet("{area}/{name}")]
        public IActionResult AddCountry(string name, int area)
        {
            return Ok($"Name = {name}");
        }

        [HttpGet]
        public IActionResult AddCountry(CountryModel country)
        {
            return Ok($"Name = {country.Name}");
        }
    }
}
