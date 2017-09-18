using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Repository;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://wiki.saucelabs.com/display/DOCS/Best+Practice%3A+Use+Environment+Variables+for+Authentication+Credentials
            //System.Collections.IDictionary dictionary = Environment.GetEnvironmentVariables();

            //ICalendarRepository calendarRepository = new O365CalendarRepository();
            INewsRepository newsRepository = new Repository.NYT.NYTRepository(Environment.GetEnvironmentVariable("HDB_NYT_KEY"));
            //ITransportationRepository transportationRepository = new MetraRepository();
            IWeatherRepository weatherRepository = new Repository.Wunderground.WundergroundRepository(Environment.GetEnvironmentVariable("HDB_NYT_KEY"));

            Task.Run(async () =>
            {
                //IEnumerable<Repository.Models.NewsItem> newsItems = await newsRepository.GetNewsItems();
                Repository.Models.WeatherData weather = await weatherRepository.GetWeather("60532");
            });

            Console.ReadKey(false);
        }
    }
}
