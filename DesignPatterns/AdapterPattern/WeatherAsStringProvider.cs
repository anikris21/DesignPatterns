namespace AdapterPattern
{
    public class WeatherAsStringProvider : IWeatherAsStringProvider
    {
        IWeatherforecastProvider _weatherforecastProvider;
        public WeatherAsStringProvider(IWeatherforecastProvider weatherforecastProvider) { 
            _weatherforecastProvider = weatherforecastProvider; 
        }

        public string Get()
        {
            return string.Join(Environment.NewLine,
           _weatherforecastProvider.Get().Select(w => $"{w.Date} | {w.TemperatureF}| {w.Summary}"));
        }

    }
}
