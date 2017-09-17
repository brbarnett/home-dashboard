using System;

using Repository;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalendarRepository calendarRepository = new O365CalendarRepository();
            INewsRepository newsRepository = new NYTRepository();
            ITransportationRepository transportationRepository = new MetraRepository();
            IWeatherRepository weatherRepository = new WundergroundRepository();
        }
    }
}
