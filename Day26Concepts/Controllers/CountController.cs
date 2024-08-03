using Day26Concepts.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Day26Concepts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountController : ControllerBase
    {
        private readonly IFirstCounter firstCounter;
        private readonly ISecondCounter secondCounter;

        public CountController(IFirstCounter firstCounter, ISecondCounter secondCounter) 
        {
            this.firstCounter = firstCounter;
            this.secondCounter = secondCounter;//To Do
        }
        [HttpGet]
        public int Get()
        {
            firstCounter.IncrementAndGet();
            return secondCounter.IncrementAndGet();
        }
    }
}
