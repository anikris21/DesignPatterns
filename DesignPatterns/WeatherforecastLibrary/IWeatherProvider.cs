using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherforecastLibrary
{
    public interface IWeatherProvider
    {
        IEnumerable<Weatherforecast> Get(int totalCount);
    }
}
