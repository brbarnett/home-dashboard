using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Repository.Models;

namespace Repository.Metra
{
    public class MetraRepository : ITransitRepository
    {
        public async Task<IEnumerable<TransitItem>> GetTrains()
        {
            throw new NotImplementedException();
        }
    }
}
