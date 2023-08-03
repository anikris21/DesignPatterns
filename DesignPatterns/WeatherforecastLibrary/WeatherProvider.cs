using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherforecastLibrary
{
    public class WeatherProvider: IWeatherProvider
    {
        public readonly string[] Summaries = new string[] {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        // 
        public IEnumerable<Weatherforecast> Get(int totalCount)
        {
            var rng = new Random();
            return Enumerable.Range(1, totalCount).Select(i =>
            new Weatherforecast
            {
                Date = DateTime.Now.AddDays(i),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }
    }
}
