using WeatherforecastLibrary;
namespace ProxyPattern
{
    public class WeatherProviderProxy: IWeatherProvider 
    {
        IWeatherProvider _weatherProvider;

        public WeatherProviderProxy(IWeatherProvider weatherProvider) 
        {
            _weatherProvider = weatherProvider; 
        }

        public IEnumerable<Weatherforecast> Get(int totalCount)
        {
            if (totalCount < 2 || totalCount > 5)
            {
                throw new ArgumentOutOfRangeException("count should be in the range");
            }
            return _weatherProvider.Get(totalCount);
        }
    }
}
