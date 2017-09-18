using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Repository.Models;

namespace Repository.O365
{
    public class O365CalendarRepository : ICalendarRepository
    {
        public Task<IEnumerable<CalendarItem>> GetCalendarItems()
        {
            throw new NotImplementedException();
        }
    }
}