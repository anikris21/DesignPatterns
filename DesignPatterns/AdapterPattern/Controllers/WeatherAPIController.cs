using Microsoft.AspNetCore.Mvc;
//using System.Collection.Generics;

namespace AdapterPattern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherAPIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new List<string>() { "a", "b", "c" };
        }
    }
}
