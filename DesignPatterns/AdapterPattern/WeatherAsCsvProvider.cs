using Csv;
namespace AdapterPattern 
{
    public class WeatherAsCsvProvider : IWeatherAsStringProvider
    {
        IWeatherforecastProvider _weatherforecastProvider;
        public WeatherAsCsvProvider(IWeatherforecastProvider weatherforecastProvider) { 
            _weatherforecastProvider = weatherforecastProvider; 
        }

        public string Get()
        {
            string[] header = new string[] { "Date", "Temperature", "Summary" };
            var csv = _weatherforecastProvider.Get().Select(w =>
            new string[] { 
                w.Date.ToString(), w.TemperatureF.ToString(), w.Summary 
            });
            return CsvWriter.WriteToText(header, csv);

           // return "";
        }
    }
}
