using Day25Concepts.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Day25Concepts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private List<AnimalsModel> animals = null;
        public AnimalsController()
        {
            animals = new List<AnimalsModel>()
            {
                new AnimalsModel() {Id = 1, Name = "Dog"},
                new AnimalsModel() {Id = 2, Name = "Lion"}
            };
        }

        [Route("", Name = "All")]
        public IActionResult GetAnimals()
        {
            return Ok(animals);
        }

        [Route("test")]
        public IActionResult GetAnimalsTest()
        {
            return LocalRedirectPermanent("~/api/animals ");
        }

        [Route("{name}")]
        public IActionResult GetAnimalsByName(string name)
        {
            if (!name.Contains("ABC"))
            {
                return BadRequest();
            }
            return Ok(animals);
        }

        [Route("{Id:int}")]
        public IActionResult GetAnimalsById(int Id)
        {
            if (Id == 0)
            {
                return BadRequest();
            }
            return Ok(animals.FirstOrDefault(x => x.Id == Id));
        }

        [HttpPost]
        public IActionResult GetAnimals(AnimalsModel animal)
        {
            animals.Add(animal);
            return CreatedAtAction("GetAnimalsById", new { Id = animal.Id }, animal);
        }
    }
}
