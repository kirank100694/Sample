using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day25Concepts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConstraintsController : ControllerBase
    {
        [Route("{Id:int:min(10):max(100):range(10,20)}")]
        public string GetById(int Id)
        {
            return "Hello Int " + Id;
        }

        [Route("{Id:minlength(5):maxlength(10):length(6):alpha}")]
        public string GetByIdString(string Id)
        {
            return "Hello String " + Id;
        }

        [Route("{id:regex(a(b|c))}")]
        public string GetByIdSRegex(string Id)
        {
            return "Hello Regex " + Id;
        }
    }
}
