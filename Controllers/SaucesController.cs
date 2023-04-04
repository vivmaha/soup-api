using Microsoft.AspNetCore.Mvc;

namespace SoupApi.Controllers
{
    [Route("api/sauces")]
    [ApiController]
    public class SaucesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "reddit", "twitter" };
        }
    }
}
