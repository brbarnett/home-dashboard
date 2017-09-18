using System.Collections.Generic;
using System.Threading.Tasks;
using Repository.Models;

namespace Repository
{
    public interface ICalendarRepository
    {
        Task<IEnumerable<CalendarItem>> GetCalendarItems();
    }
}
