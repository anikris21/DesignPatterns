using Microsoft.AspNetCore.Mvc;

namespace DecoratorPattern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CakeController : Controller
    {
        ICakeMessageDecorator _cakeMessageDecorator;
        ICake _cake;
        public CakeController(ICakeMessageDecorator cakeMessageDecorator, ICake cake)
        {
            _cakeMessageDecorator = cakeMessageDecorator;
            _cake = cake;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            List<string> r = new List<string>();
            _cakeMessageDecorator.AddMessage("Morning!");
            var enumerator = _cake.PrintLayers();
            while (enumerator.MoveNext())
            {
                r.Add(enumerator.Current);
            }

            //IEnumerable
            return r;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
