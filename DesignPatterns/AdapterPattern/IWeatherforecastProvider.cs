namespace AdapterPattern
{
     public interface IWeatherforecastProvider
    {
        IEnumerable<Weatherforecast> Get();
    }
}
