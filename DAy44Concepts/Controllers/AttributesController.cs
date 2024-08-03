using DAy44Concepts.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DAy44Concepts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttributesController : ControllerBase
    {
        [HttpPost]
        public IActionResult AddCountry([FromQuery] int Id, [FromQuery] CountryModel model)
        {
            return Ok($"Name = {model.Name}");
        }

        [HttpPost("{name}/{Population}/{Area}")]
        public IActionResult UsingFromRoute([FromRoute] CountryModel model, [FromQuery] int Id)
        {
            return Ok($"Name = {model.Name}");
        }

        [HttpPost]
        public IActionResult UsingFromBody([FromRoute] int Id, [FromBody] CountryModel model)
        {
            return Ok($"Name = {model.Name}");
        }

        [HttpPost]
        public IActionResult UsingFromForm([FromRoute] int Id, [FromForm] CountryModel model)
        {
            return Ok($"Name = {model.Name}");
        }

        [HttpPost]
        public IActionResult UsingFromHeder([FromRoute] int Id, [FromHeader] string developer, [FromHeader] string course)
        {
            return Ok($"Name = {developer}");
        }
    }
}
