
using AdapterPattern;
namespace AdapterPattern
{
     class WeatherforecastProvider: IWeatherforecastProvider
    {
        public readonly string[] Summaries = new string[] { 
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" 
        };

        public IEnumerable<Weatherforecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(i =>
            new Weatherforecast
            {
                Date = DateTime.Now.AddDays(i),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }


    }
}
