using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day43Concepts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Route("[controller]/[action]")]  //Token Replacement in routing
    public class ValuesController : ControllerBase
    {
        [Route("~/api/get-all")]
        //[Route("~/getall")]  //Setup multiple URLs for single resource (Action method)
        //[Route("~/get-all")]  //Setup multiple URLs for single resource (Action method)
        public string GetAll()
        {
            return "Hello from get all";
        }

        [Route("~/api/get-all-authors")]
        //[Route("~/getall")]  //This is not possible
        public string GetAllAuthors()
        {
            return "Hello from get all Authors";
        }

        //Variables in Routing
        [Route("~/books/{Id}")]
        //[Route("{Id}")]
        public string GetById(int Id)
        {
            return "Hello User" + Id;
        }

        [Route("~/books/{Id}/author/{authorId}")]
        public string GetAuthorAddressById(int Id, int authorId)
        {
            return "Hello Author Address " + Id + " " + authorId;
        }

        //Query String in Routing
        [Route("~/Search")]
        public string SerchBooks(int Id, int authorId, string name, int rating, int price)
        {
            return "Hello from search ";
        }
    }
}
