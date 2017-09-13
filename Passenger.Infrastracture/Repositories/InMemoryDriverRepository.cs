using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Passenger.Core.Domain;
using Passenger.Core.Repositories;

namespace Passenger.Infrastracture.Repositories
{
    public class InMemoryDriverRepository : IDriverRepository
    {
        private static ISet<Driver> _drivers = new HashSet<Driver>();
        public async Task AddAsync(Driver driver)
        {
            _drivers.Add(driver);
        }

        public async Task<Driver> GetAsync(Guid userId)
            => _drivers.Single(x => x.UserId == userId);

        public async Task<IEnumerable<Driver>> GetAllAsync()
            => _drivers;

        public async Task UpdateAsync(Driver driver)
        {
            
        }
    }
}