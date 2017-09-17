using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Repository.Models;

namespace Repository
{
    public interface INewsRepository
    {
        Task<IEnumerable<NewsItem>> GetNewsItems();
    }
}
