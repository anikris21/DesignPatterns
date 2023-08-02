using Microsoft.AspNetCore.Mvc;
//using System.Collections.Generics;
using AdapterPattern;

namespace AdapterPattern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherAPIController : Controller
    {
        private readonly IWeatherforecastProvider _weatherforecastProvider;
        private readonly IWeatherAsStringProvider _weatherAsStringProvider;
        public WeatherAPIController(IWeatherAsStringProvider weatherAsStringProvider) { 
            _weatherAsStringProvider = weatherAsStringProvider; 
        }
        //public WeatherAPIController(IWeatherforecastProvider weatherforecastProvider) { _weatherforecastProvider = weatherforecastProvider; }


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public string Get()
        {
            return _weatherAsStringProvider.Get();
            //return _weatherforecastProvider.Get();
        }



        [HttpPost]
        public IEnumerable<string> Post()
        {
            //_weatherforecastProvider.Get();
            return new List<string>() { "a", "b", "c" };
        }
    }
}
